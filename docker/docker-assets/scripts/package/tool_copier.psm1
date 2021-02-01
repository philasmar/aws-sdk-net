$ErrorActionPreference = "Stop"

function Invoke-CopyForTools([System.IO.DirectoryInfo]$DirectoryPath)
{
    $testInputPackagePath = [IO.Path]::Combine($DirectoryPath, "bin", "Release", "*.nupkg")
    if (-not(Test-Path $testInputPackagePath -Type Leaf))
    {
        Write-Host "$testInputPackagePath not found. It's a normal package."
        return
    }

    $inputPackage = Get-Item $testInputPackagePath
    $originalDirectory = $inputPackage.Directory
    Write-Host "Found existing nupkg $( $inputPackage.FullName ). Checking if publish folder exists."
    $testPath = [IO.Path]::Combine($originalDirectory, "*", "publish")
    if (-not(Test-Path $testPath -PathType Container))
    {
        Write-Host "$testPath not found. Repacking."
        return
    }

    Write-Host "Publish folder exists."
    $destinationRoot = (Join-Path -Path $originalDirectory -ChildPath $inputPackage.BaseName).ToString()
    Rename-Item $inputPackage.FullName -NewName ($inputPackage.BaseName + ".zip") -PassThru |
            Expand-Archive -DestinationPath $destinationRoot
    Write-Host "Extracted nupkg to $destinationRoot."
    $destinationPath = Get-Item ([IO.Path]::Combine($destinationRoot, "tools", "*", "any"))
    $sourceDir = Get-Item $testPath
    Write-Host "Copying items to nupkg."
    Copy-Item (Join-Path -Path $sourceDir -ChildPath "*") -Destination $destinationPath -Recurse -Force

    # Remove parts of nuget package known to cause problems.
    Remove-Item (Join-Path -Path $destinationRoot -ChildPath "*.xml") -Force
    Remove-Item (Join-Path -Path $destinationRoot -ChildPath "_rels") -Recurse -Force
    Remove-Item (Join-Path -Path $destinationRoot -ChildPath "package") -Recurse -Force

    $nuspecFile = Get-Item (Join-Path -Path $destinationRoot -ChildPath "*.nuspec")
    # NuGet writes to the output, which is returned. So, redirect output to null.
    $null = nuget pack $nuspecFile -BasePath $destinationRoot -OutputDirectory $originalDirectory

    $resultPackage = Get-Item (Join-Path -Path $originalDirectory -ChildPath "*.nupkg")
    return $resultPackage
}