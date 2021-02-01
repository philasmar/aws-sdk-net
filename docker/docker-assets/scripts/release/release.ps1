$ErrorActionPreference = "Stop"

Import-Module AWS.Tools.Common
Import-Module AWS.Tools.SecretsManager
Import-Module AWS.Tools.SecurityToken

Import-Module $PSScriptRoot/nuget_operations.psm1

Set-Location codebuild-output
$currentLocation = Get-Location

Publish-Packages -DirectoryPath $currentLocation -NugetSourceUrl $env:NUGET_SOURCE_URL -RoleArn $env:NUGET_API_KEY_ROLE_ARN -RoleSessionName "NugetKeyRetriever" -SecretKey $env:NUGET_API_KEY_SECRET_KEY