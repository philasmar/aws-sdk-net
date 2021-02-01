$ErrorActionPreference = "Stop"

Import-Module AWS.Tools.Common
Import-Module AWS.Tools.SecretsManager
Import-Module AWS.Tools.SecurityToken
Import-Module AWS.Tools.S3

Import-Module $PSScriptRoot/authenticode_operations.psm1

if ($env:WORKING_DIRECTORY_PATH)
{
    Set-Location $env:WORKING_DIRECTORY_PATH
}
$currentLocation = Get-Location

$filter = if ($env:WORKING_DIRECTORY_FILTER)
{
    if ($env:WORKING_DIRECTORY_FILTER -eq "NONE")
    {
        "*"
    }
    else
    {
        $env:WORKING_DIRECTORY_FILTER
    }
}
else
{
    "*\bin\Release\*"
}

Write-Host "Invoking the CodeSign Module"
Invoke-CodeSign -DirectoryPath $currentLocation -Filter $filter -RoleArn $env:CERT_ROLE_ARN -RoleSessionName "CertificateRetriever" -BucketName $env:CERT_BUCKET -CertificateObjectKey $env:CERT_OBJECT_KEY -SecretPasswordKey $env:CERT_SECRET_KEY