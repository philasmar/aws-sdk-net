$ErrorActionPreference = "Stop"

function Get-RoleCredentials([string]$RoleArn, [string]$RoleSessionName)
{
    Use-STSRole -RoleArn $RoleArn -RoleSessionName $RoleSessionName | Select-Object -ExpandProperty Credentials
}

function Set-NugetPackageSources([string]$NugetPackageSources)
{
    if($NugetPackageSources)
    {
        nuget sources Disable -Name "nuget.org"
        if (-not $?)
        {
            throw "Unable to disable Nuget.org source. Erroring due to unpredicatable behavior."
        }

        $sourcePairs = $NugetPackageSources.Split(",");
        foreach($sourcePair in $sourcePairs)
        {
            $nameAndUrl = $sourcePair.Split("!:!")
            if($nameAndUrl[1] -eq "https://api.nuget.org/v3/index.json")
            {
                nuget sources Enable -Name "nuget.org"
            }
            else
            {
                nuget sources Add -Name $nameAndUrl[0] -Source $nameAndUrl[1]
            }

            if (-not $?)
            {
                throw "Unable to add source $($nameAndUrl[0])."
            }
        }
    }
}

Export-ModuleMember -Function "Get-RoleCredentials"
Export-ModuleMember -Function "Set-NugetPackageSources"