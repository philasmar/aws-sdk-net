$ErrorActionPreference = "Stop"

function Invoke-MSBuildTask([string]$Project, [string]$Task)
{
    $task, $params = $Task.Split(" ")
    dotnet msbuild $Project /t:$task $params
    if(-not $?)
    {
        throw "Build Failed."
    }
}

function Invoke-MSBuild([string]$Project, [string[]]$Tasks)
{
    $Tasks | ForEach-Object { Invoke-MSBuildTask -Project $Project -Task $_ }
}

Export-ModuleMember -Function "Invoke-MSBuild"