$ErrorActionPreference = "Stop"

Import-Module $PSScriptRoot/sanity_checks.psm1

if($env:DOTNET_TOOL_SANITY_CHECK_LIST)
{
    Test-InstallDotnetTools -ToolsConfig $env:DOTNET_TOOL_SANITY_CHECK_LIST
}