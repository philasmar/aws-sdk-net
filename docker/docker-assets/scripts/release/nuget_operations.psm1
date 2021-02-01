Import-Module $PSScriptRoot/../common/utility.psm1

function Publish-Package([string]$PackagePath, [string]$NugetSourceUrl, [string]$ApiKey)
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

    # Always compare against NuGet.org. MyGet list doesn't work. Using query API so we don't get throttled.
    $queryResult = Invoke-WebRequest "https://api-v2v3search-0.nuget.org/query?q=PackageId:$packageName&prerelease=true" -UseBasicParsing |
            Select-Object -ExpandProperty Content |
            ConvertFrom-JSON

    $numberOfHits = $queryResult.totalHits
    if ($numberOfHits -gt 1)
    {
        throw "More than one package returned from query. Don't know what to do. Aborting."
    }
    elseif ($numberOfHits -eq 1)
    {
        Write-Host "Exactly one package was returned from query. Comparing."

        $queryResultData = $queryResult.data
        $remoteName = $queryResultData.id
        $remoteVersion = $queryResultData.version

        Write-Host "The remote name is $remoteName and the version is $remoteVersion"

        if ($remoteName -ne $packageName)
        {
            throw "Remote name $remoteName does not match local name $packageName."
        }

        if ($remoteVersion -eq $packageVersion)
        {
            Write-Host "$remoteName already has version $remoteVersion pushed. Skipping."
            return
        }
    }

    dotnet nuget push $PackagePath --source $NugetSourceUrl --api-key $ApiKey
}

function Get-NugetApiKey([string]$SecretKey, [Amazon.Runtime.AWSCredentials]$Credentials)
{
    Get-SECSecretValue -SecretId $SecretKey -Credential $Credentials | Select-Object -ExpandProperty SecretString | ConvertFrom-Json | Select-Object -ExpandProperty Key
}

function Publish-Packages([System.Management.Automation.PathInfo]$DirectoryPath, [string]$NugetSourceUrl, [string]$RoleArn, [string]$RoleSessionName, [string]$SecretKey)
{
    $nupkgFiles = Get-ChildItem -Path $DirectoryPath -Filter "*.nupkg"

    if ($env:IS_DRY_RUN -eq 'true')
    {
        $nupkgFiles | ForEach-Object { Write-Host "Skipping push of $_ because IS_DRY_RUN is true." }
    } else {
        $credentials = Get-RoleCredentials -RoleArn $RoleArn -RoleSessionName $RoleSessionName
        $nugetApiKey = Get-NugetApiKey -SecretKey $SecretKey -Credentials $credentials
        $nupkgFiles | ForEach-Object { Publish-Package -PackagePath $_.FullName -NugetSourceUrl $NugetSourceUrl -ApiKey $nugetApiKey }
    }
}

Export-ModuleMember -Function "Publish-Packages"