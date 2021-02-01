$ErrorActionPreference = "Stop"

Import-Module AWS.Tools.Common
Import-Module AWS.Tools.SecretsManager
Import-Module AWS.Tools.SecurityToken
Import-Module AWS.Tools.CodeArtifact

Import-Module $PSScriptRoot/code_artifact_operations.psm1

Set-Location codeartifact-output
$currentLocation = Get-Location

Publish-Packages -DirectoryPath $env:currentLocation -SourceUrl $env:CODE_ARTIFACT_SOURCE_URL -Domain $env:CODE_ARTIFACT_DOMAIN -DomainOwner $env:CODE_ARTIFACT_DOMAIN_OWNER -Repository $env:CODE_ARTIFACT_REPOSITORY

