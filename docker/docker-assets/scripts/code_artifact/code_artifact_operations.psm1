Import-Module $PSScriptRoot/../common/utility.psm1

function Publish-Package([string]$PackagePath, [string]$CodeArtifactSourceUrl)
{
    $nugetPackage = Get-Item $PackagePath

    $newZip = Copy-Item $nugetPackage ($( New-TemporaryFile ).FullName + ".zip") -PassThru
    $destinationPath = Join-Path -Path $newZip.Directory -ChildPath $newZip.BaseName
    Remove-Item $destinationPath
    Expand-Archive $newZip -DestinationPath $destinationPath
    $nuspecSearchPath = Join-Path -Path $destinationPath -ChildPath "*.nuspec"
    $nuspecFile = Get-Item $nuspecSearchPath
    [xml]$nuspecContents = Get-Content $nuspecFile
    $nuspecMetadata = $nuspecContents.package.metadata

    $packageName = $nuspecMetadata.id
    $packageVersion = $nuspecMetadata.version

    Write-Host "The package name is $packageName. The version is $packageVersion"

    dotnet nuget push $PackagePath --source $CodeArtifactSourceUrl
    if (!$?)
    {
        Write-Error "Failed to push $packageName."
    }
}

function Publish-Packages([System.Management.Automation.PathInfo]$DirectoryPath, [string]$SourceUrl, [string]$Domain, [string]$DomainOwner, [string]$Repository)
{
    $nupkgFiles = Get-ChildItem -Path $DirectoryPath -Filter "*.nupkg"

    $authorizationToken = Get-CAAuthorizationToken -Domain $Domain -DomainOwner $DomainOwner -Select AuthorizationToken
    dotnet nuget add source $SourceUrl -n "${Domain}/${Repository}" -u "aws" -p $authorizationToken
    $nupkgFiles | ForEach-Object { Publish-Package -PackagePath $_.FullName -CodeArtifactSourceUrl $SourceUrl }
}

Export-ModuleMember -Function "Publish-Packages"