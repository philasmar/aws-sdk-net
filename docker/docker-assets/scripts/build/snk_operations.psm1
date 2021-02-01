$ErrorActionPreference = "Stop"

Import-Module $PSScriptRoot/../common/utility.psm1

function Assert-FileExists([System.Management.Automation.PathInfo]$Path, [string]$FileName)
{
    if (-Not(Test-Path $Path -PathType Container))
    {
        throw "Source artifact is not a directory: " + $Path.ToString()
    }

    $snkPath = Join-Path $Path.ToString() -ChildPath $FileName
    Test-Path $snkPath -PathType Leaf
}

function Get-SecretSnk([System.Management.Automation.PathInfo]$Path, [string]$FileName, [Amazon.Runtime.AWSCredentials]$Credentials, [string]$SecretKey)
{
    $snkFilePath = Join-Path $Path.ToString() -ChildPath $FileName

    $snkcontents = Get-SECSecretValue -SecretId $SecretKey -Credential $Credentials | Select-Object -ExpandProperty "SecretBinary"

    $fileStream = New-Object -TypeName "System.IO.FileStream" -ArgumentList $snkFilePath, Create
    $snkcontents.WriteTo($fileStream)
    $fileStream.Flush()
    $fileStream.Dispose()
}

function Get-Snk([System.Management.Automation.PathInfo]$DirectoryPath, [string]$RemoveIfExists, [string]$RoleArn, [string]$RoleSessionName, [string]$SecretKey, [string]$FileName = "strongname.snk")
{
    Write-Host "Getting the SNK"
    Write-Host "Remove if exists is set to " $RemoveIfExists
    Write-Host "File exists: " (Assert-FileExists -Path $DirectoryPath -FileName $FileName)
    if (($RemoveIfExists -eq "true") -and (Assert-FileExists -Path $DirectoryPath -FileName $FileName))
    {
        Write-Host "Removing existing SNK File"
        Remove-Snk -DirectoryPath $DirectoryPath -FileName $FileName
    }
    if (-Not(Assert-FileExists -Path $DirectoryPath -FileName $FileName))
    {
        Write-Host "Pulling down production SNK file"
        $credentials = Get-RoleCredentials -RoleArn $RoleArn -RoleSessionName $RoleSessionName
        Get-SecretSnk -Path $DirectoryPath -FileName $FileName -Credentials $credentials -SecretKey $SecretKey
    }
}

function Remove-Snk([System.Management.Automation.PathInfo]$DirectoryPath, [string]$FileName = "strongname.snk")
{
    Write-Host "Deleting SNK file " $FileName " in " $DirectoryPath.Path
    $snkFilePath = Join-Path $DirectoryPath.ToString() -ChildPath $FileName
    Remove-Item $snkFilePath
}

Export-ModuleMember -Function "Get-Snk"
Export-ModuleMember -Function "Remove-Snk"