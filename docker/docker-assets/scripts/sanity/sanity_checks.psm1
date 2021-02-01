$ErrorActionPreference = "Stop"

function Test-InstallDotnetTool([string]$PackageId, [string]$Command, [Boolean]$ShouldTestHelp)
{
    dotnet tool install $PackageId --add-source .
    if (-not $?)
    {
        throw "Failed to install tool $PackageId."
    }
    if($ShouldTestHelp)
    {
        dotnet $Command help
        if (-not $?)
        {
            throw "Command 'dotnet $Command help' failed for $PackageId."
        }
    }
}

function Test-InstallDotnetTools([string]$ToolsConfig)
{
    # We need to make sure we are not just installing the packages from NuGet.org.
    Copy-Item -Path "$PSScriptRoot/nuget.config" -Destination .
    # Since we are installing "locally", we need to create the tools manifest
    dotnet new tool-manifest
    if (-not $?)
    {
        throw "Could not create the tools manifest."
    }
    # The testing configuration is slighly complex, so it is passed as JSON
    $toolsToCheck = ConvertFrom-Json $ToolsConfig
    $toolsToCheck | ForEach-Object { Test-InstallDotnetTool -PackageId $_.package_id -Command $_.command -ShouldTestHelp $_.should_test_help }
}

Export-ModuleMember Test-InstallDotnetTools