$ErrorActionPreference = "Stop"

Import-Module AWS.Tools.Common

Import-Module $PSScriptRoot/../common/msbuild_tasks.psm1
Import-Module $PSScriptRoot/../common/utility.psm1

function Invoke-DotnetTest()
{
    $testProjects = if ($env:TEST_LIST)
    {
        $env:TEST_LIST -split ","
    }
    else
    {
        $searchPath = if ($env:WORKING_DIRECTORY_FILTER)
        {
            if ($env:WORKING_DIRECTORY_FILTER -eq "NONE")
            {
                Get-Location
            }
            else
            {
                $env:WORKING_DIRECTORY_FILTER
            }
        }
        else
        {
            "test/unit"
        }

        Get-ChildItem -Path $searchPath -Recurse -Include "*.csproj", "*.fsproj", "*.vbproj"
    }

    if ($testProjects -ne "NONE")
    {
        $testProjects | ForEach-Object { dotnet test --verbosity normal $_ --configuration Release }
    }
}

if ($env:WORKING_DIRECTORY_PATH)
{
    Set-Location $env:WORKING_DIRECTORY_PATH
}

Write-Host "Starting Tests..."

if (![string]::IsNullOrEmpty($env:TESTING_ROLE_ARN))
{
    Write-Host "Writing [default] profile to ~/.aws/credentials to assume role $env:TESTING_ROLE_ARN during testing."

    # Build the CredentialProfile in memory
    $assumeRoleProfileOptions = New-Object Amazon.Runtime.CredentialManagement.CredentialProfileOptions
    $assumeRoleProfileOptions.RoleArn = $env:TESTING_ROLE_ARN
    $assumeRoleProfileOptions.CredentialSource = "EcsContainer"
    $assumeRoleProfile = New-Object Amazon.Runtime.CredentialManagement.CredentialProfile -ArgumentList "default",$assumeRoleProfileOptions

    # Save the [default] profile to ~/.aws/credentials so the SDK will pick it up during the test runs
    $sharedCredsFile = New-Object -TypeName Amazon.Runtime.CredentialManagement.SharedCredentialsFile
    $sharedCredsFile.RegisterProfile($assumeRoleProfile)
}

Set-NugetPackageSources -NugetPackageSources $env:PACKAGE_SOURCES

if ($env:RUNNER_TYPE -eq "MSBUILD")
{
    Write-Host "Using MSBuild to test."
    Invoke-MSBuild -Project $env:MSBUILD_PROJECT -Tasks $( $env:MSBUILD_TASK_LIST -split "," )
}
elseif ($env:RUNNER_TYPE -eq "DOTNET")
{
    Write-Host "Using the dotnet CLI to test."
    Invoke-DotnetTest
}
else
{
    throw "Runner type $env:RUNNER_TYPE is unknown."
}
