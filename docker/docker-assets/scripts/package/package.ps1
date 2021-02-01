$ErrorActionPreference = "Stop"

Import-Module AWS.Tools.Common
Import-Module AWS.Tools.SecretsManager
Import-Module AWS.Tools.SecurityToken

Import-Module $PSScriptRoot/../common/msbuild_tasks.psm1
Import-Module $PSScriptRoot/../common/utility.psm1
Import-Module $PSScriptRoot/tool_copier.psm1

function Get-BuildList([string]$WorkingDirectoryFilter, [string[]]$IncludeList)
{
    $searchPath = if ($WorkingDirectoryFilter)
    {
        Write-Host "Working directory filter supplied: $WorkingDirectoryFilter"
        if ($WorkingDirectoryFilter -eq "NONE")
        {
            Get-Location
        }
        else
        {
            $WorkingDirectoryFilter
        }
    }
    else
    {
        "src"
    }
    Write-Host "Running command Get-ChildItem -Path $searchPath -Recurse -Include $IncludeList"
    Get-ChildItem -Path $searchPath -Recurse -Include $IncludeList
}

function Invoke-DotnetPack([string]$OutputDirectory, [string]$VersionSuffix = "")
{
    $packageTargets = if ($env:DOTNET_PACKAGE_LIST)
    {
        $env:DOTNET_PACKAGE_LIST -split "," | Get-Item
    }
    else
    {
        Get-BuildList -WorkingDirectoryFilter $env:DOTNET_WORKING_DIRECTORY_FILTER -IncludeList "*.csproj", "*.fsproj", "*.vbproj"
    }

    $packageTargets | ForEach-Object {
        $alreadyPackaged = Invoke-CopyForTools -DirectoryPath $_.Directory
        if ($alreadyPackaged)
        {
            Write-Host "The package $alreadyPackaged is already packed. Copying to $OutputDirectory."
            Copy-Item -Path $alreadyPackaged -Destination $OutputDirectory
        }
        else
        {
            dotnet restore $_
            if ($VersionSuffix -eq "")
            {
                dotnet pack $_ --configuration Release --no-build --output $OutputDirectory
            }
            else
            {
                dotnet pack $_ --configuration Release --no-build --output $OutputDirectory --version-suffix $VersionSuffix
            }

            if (!$?)
            {
                Write-Error "Failed to pack $_"
            }
        }
    }
}

function Invoke-NugetPack([string]$OutputDirectory, [string]$VersionSuffix = "")
{
    $packageTargets = if ($env:NUGET_PACKAGE_LIST)
    {
        $env:NUGET_PACKAGE_LIST -split "," | Get-Item
    }
    else
    {
        Get-BuildList -WorkingDirectoryFilter $env:NUGET_WORKING_DIRECTORY_FILTER -IncludeList "*.nuspec"
    }

    nuget restore

    $packageTargets | ForEach-Object {
        if ($VersionSuffix -eq "")
        {
            nuget pack $_ -OutputDirectory $OutputDirectory
        }
        else
        {
            nuget pack $_ -OutputDirectory $OutputDirectory -Suffix $VersionSuffix
        }

        if (!$?)
        {
            Write-Error "Failed to pack $_"
        }
    }
}

function Get-VersionSuffix([string]$ReleaseType)
{
    $commitId = ($env:COMMIT_ID).Substring(0, 7);
    $timestamp = Get-Date -Format "yyyyMMddHHmmss";
    return "$ReleaseType.$timestamp.$commitId"
}

$rootDirectory = Get-Location
$outputDirectory = Join-Path -Path $( Get-Location ) -ChildPath "codebuild-output"
$codeArtifactOutputDirectory = Join-Path -Path $( Get-Location ) -ChildPath "codeartifact-output"
New-Item $outputDirectory -ItemType Container

Write-Host "Packing..."

Set-NugetPackageSources -NugetPackageSources $env:PACKAGE_SOURCES

if ($env:RUNNER_TYPE -ne "NUGET" -and $env:RUNNER_TYPE -ne "DOTNET" -and $env:RUNNER_TYPE -ne "MIXED")
{
    throw "Runner type $env:RUNNER_TYPE is unknown."
}

if ($env:RUNNER_TYPE -eq "NUGET" -or $env:RUNNER_TYPE -eq "MIXED")
{
    Write-Host "Using NuGet CLI to pack."
    if ($env:NUGET_WORKING_DIRECTORY_PATH)
    {
        Set-Location $env:NUGET_WORKING_DIRECTORY_PATH
    }
    Invoke-NugetPack -OutputDirectory $outputDirectory
    if ($env:IS_CODE_ARTIFACT_RELEASE_ENABLED -eq "true")
    {
        $VersionSuffix = Get-VersionSuffix -ReleaseType "beta"
        Invoke-NugetPack -OutputDirectory $codeArtifactOutputDirectory -VersionSuffix $VersionSuffix
    }
    Set-Location $rootDirectory
}
if ($env:RUNNER_TYPE -eq "DOTNET" -or $env:RUNNER_TYPE -eq "MIXED")
{
    Write-Host "Using the dotnet CLI to pack."
    if ($env:DOTNET_WORKING_DIRECTORY_PATH)
    {
        Set-Location $env:DOTNET_WORKING_DIRECTORY_PATH
    }
    Invoke-DotnetPack -OutputDirectory $outputDirectory
    if ($env:IS_CODE_ARTIFACT_RELEASE_ENABLED -eq "true")
    {
        $VersionSuffix = Get-VersionSuffix -ReleaseType "beta"
        Invoke-DotnetPack -OutputDirectory $codeArtifactOutputDirectory -VersionSuffix $VersionSuffix
    }
    Set-Location $rootDirectory
}