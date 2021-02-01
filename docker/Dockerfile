# escape=`

# Use the latest Windows Server Core image with .NET Framework 4.8.
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019

# Restore the default Windows shell for correct batch processing.
SHELL ["cmd", "/S", "/C"]

#Get chocolatey
RUN powershell -Command iex ((new-object net.webclient).DownloadString(‘https://chocolatey.org/install.ps1‘));

#Install environment
RUN choco install -y git
RUN choco install -y dotnetcore-sdk --version=1.1.14
RUN choco install -y dotnetcore-sdk --version=2.1.811
RUN choco install -y dotnetcore-sdk --version=3.1.403

# Microsoft made building 3.5 with dotnet build difficult. We need to provide all the reference assemblies ourselves.
COPY ["docker-assets/35-reference-assemblies", "C:/Program Files (x86)/Reference Assemblies/Microsoft/Framework/.NETFramework/v3.5/Profile/Client"]

# Download the Build Tools bootstrapper.
ADD https://aka.ms/vs/16/release/vs_professional.exe C:\TEMP\vs_professional.exe

# Install Build Tools with the Microsoft.VisualStudio.Workload.AzureBuildTools workload, excluding workloads and components with known issues.
# https://docs.microsoft.com/en-us/visualstudio/install/workload-component-id-vs-professional?view=vs-2019&preserve-view=true
RUN C:\TEMP\vs_professional.exe --quiet --wait --norestart `
    --add Microsoft.VisualStudio.Workload.ManagedDesktop `
    --add Microsoft.VisualStudio.Workload.VisualStudioExtension `
    --add Microsoft.VisualStudio.Component.PortableLibrary `
    --add Microsoft.VisualStudio.Component.VSSDK `
    --add Microsoft.Net.Component.3.5.DeveloperTools `
    || IF "%ERRORLEVEL%"=="3010" EXIT 0

# Enable detection of running in a container
ENV DOTNET_RUNNING_IN_CONTAINER=true

# Enable correct mode for dotnet watch (only mode supported in a container)
ENV DOTNET_USE_POLLING_FILE_WATCHER=true

# Skip extraction of XML docs - generally not useful within an image/container - helps performance
ENV NUGET_XMLDOC_MODE=skip

WORKDIR C:\CodeBase

RUN git clone https://github.com/philasmar/aws-sdk-net.git --depth 1

ENTRYPOINT ["C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Professional\\Common7\\Tools\\VsDevCmd.bat", "&&", "powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]