$ErrorActionPreference = "Stop"

Import-Module AWS.Tools.Common
Import-Module AWS.Tools.SecretsManager
Import-Module AWS.Tools.SecurityToken

Import-Module $PSScriptRoot/snk_operations.psm1
Import-Module $PSScriptRoot/../common/msbuild_tasks.psm1
Import-Module $PSScriptRoot/../common/utility.psm1

function Invoke-DotnetBuild()
{
    $sourceProjects = if ($env:BUILD_LIST)
    {
        $env:BUILD_LIST -split ","
    }
    else
    {
        $searchPath = if ($env:WORKING_DIRECTORY_FILTER)
        {
            if ($env:WORKING_DIRECTORY_FILTER -eq "NONE")
            {
                Get-Location
            }
            else
            {
                $env:WORKING_DIRECTORY_FILTER
            }
        }
        else
        {
            "src"
        }
        Get-ChildItem -Path $searchPath -Recurse -Include "*.csproj", "*.fsproj", "*.vbproj"
    }

    foreach ($project in $sourceProjects)
    {
        dotnet build $project --configuration Release
        if (-not $?)
        {
            throw "BUILD FAILED"
        }
    }
}

if ($env:WORKING_DIRECTORY_PATH)
{
    Set-Location $env:WORKING_DIRECTORY_PATH
}
$currentLocation = Get-Location

Write-Host "Invoking the SNK Module"
Get-Snk -DirectoryPath $currentLocation -RemoveIfExists $env:SNK_REMOVE_IF_EXISTS -RoleArn $env:SNK_ROLE_ARN -RoleSessionName "SnkRetriever" -SecretKey $env:SNK_SECRET_KEY -FileName $env:SNK_FILE_NAME

Write-Host "Building..."

Set-NugetPackageSources -NugetPackageSources $env:PACKAGE_SOURCES

if ($env:RUNNER_TYPE -eq "MSBUILD")
{
    Write-Host "Using MSBuild to build."
    Invoke-MSBuild -Project $env:MSBUILD_PROJECT -Tasks $( $env:MSBUILD_TASK_LIST -split "," )
}
elseif ($env:RUNNER_TYPE -eq "DOTNET")
{
    Write-Host "Using the dotnet CLI to build."
    Invoke-DotnetBuild
}
else
{
    throw "Runner type $env:RUNNER_TYPE is unknown."
}

Remove-Snk -DirectoryPath $currentLocation -FileName $env:SNK_FILE_NAME