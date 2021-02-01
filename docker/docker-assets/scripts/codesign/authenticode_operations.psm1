$ErrorActionPreference = "Stop"

Import-Module $PSScriptRoot/../common/utility.psm1

function Get-CodeSigningCertificate([string]$BucketName, [string]$Key, [Amazon.Runtime.AWSCredentials]$Credentials)
{
    Read-S3Object -BucketName $BucketName -Key $Key -File ($( New-TemporaryFile ).FullName + ".pfx")  -Credential $Credentials
}

function Get-CodeSigningPassword([string]$SecretKey, [Amazon.Runtime.AWSCredentials]$Credentials)
{
    Get-SECSecretValue -SecretId $SecretKey -Credential $Credentials | Select-Object -ExpandProperty SecretString | ConvertFrom-Json | Select-Object -ExpandProperty Key
}

function Invoke-CodeSignSingle([string]$Certificate, [string]$CertificatePassword, [string]$AssemblyPath)
{
    $signtoolLocation = $( Join-Path -Path $PSScriptRoot -ChildPath signtool.exe )
    & $signtoolLocation sign /f $Certificate /p $CertificatePassword /tr "http://timestamp.digicert.com" /td sha256 /fd sha256 $AssemblyPath
    if(-not $?)
    {
        throw "Signing failed for assembly $AssemblyPath. Aborting."
    }
}

function Invoke-CodeSign([System.Management.Automation.PathInfo]$DirectoryPath, [string]$Filter, [string]$RoleArn, [string]$RoleSessionName, [string]$BucketName, [string]$CertificateObjectKey, [string]$SecretPasswordKey)
{
    $credentials = Get-RoleCredentials -RoleArn $RoleArn -RoleSessionName $RoleSessionName
    $certificate = Get-CodeSigningCertificate -BucketName $BucketName -Key $CertificateObjectKey -Credentials $credentials
    $certificatePassword = Get-CodeSigningPassword -SecretKey $SecretPasswordKey -Credentials $credentials

    $assembliesToSign = Get-ChildItem -Path $DirectoryPath -Recurse -Filter "*.dll" | where-object { $_.FullName -like $Filter }

    # Something isn't right. There should at least be 1 assembly.
    if ($assembliesToSign.Length -lt 1)
    {
        throw "Did not find any assemblies to sign. This is an invalid configuration. Aborting."
    }

    foreach($assembly in $assembliesToSign)
    {
        Invoke-CodeSignSingle -Certificate $certificate -CertificatePassword $certificatePassword -AssemblyPath $assembly.FullName
    }
}

Export-ModuleMember -Function "Invoke-CodeSign"