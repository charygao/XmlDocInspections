[CmdletBinding()]
Param(
  [Parameter()] [string] $NugetExecutable = "Shared\.nuget\nuget.exe",
  [Parameter()] [string] $Configuration = "Debug",
  [Parameter()] [string] $Version = "0.0.0.1",
  [Parameter()] [string] $BranchName,
  [Parameter()] [string] $CoverageBadgeUploadToken,
  [Parameter()] [string] $NugetPushKey
)

Set-StrictMode -Version 2.0; $ErrorActionPreference = "Stop"; $ConfirmPreference = "None"

. Shared\Build\BuildFunctions

$BuildOutputPath = "Build\Output"
$SolutionFilePath = "XmlDocInspections.sln"
$MSBuildPath = (Get-ChildItem "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\*\MSBuild\15.0\Bin\MSBuild.exe").FullName
$NUnitAdditionalArgs = "--x86 --labels=All --agents=1"
$NUnitTestAssemblyPaths = @(
    "Src\XmlDocInspections.Plugin.Tests\bin\R20163\$Configuration\XmlDocInspections.Plugin.Tests.R20163.dll"
    "Src\XmlDocInspections.Plugin.Tests\bin\R20171\$Configuration\XmlDocInspections.Plugin.Tests.R20171.dll"
    "Src\XmlDocInspections.Plugin.Tests\bin\R20172\$Configuration\XmlDocInspections.Plugin.Tests.R20172.dll"
)
$NUnitFrameworkVersion = "net-4.5"
$TestCoverageFilter = "+[XmlDocInspections*]* -[XmlDocInspections*]ReSharperExtensionsShared.*"
$NuspecPath = "Src\XmlDocInspections.nuspec"
$NugetPackProperties = @(
    "Version=$(CalcNuGetPackageVersion 20163);Configuration=$Configuration;DependencyVer=[7.0];BinDirInclude=bin\R20163"
    "Version=$(CalcNuGetPackageVersion 20171);Configuration=$Configuration;DependencyVer=[8.0];BinDirInclude=bin\R20171"
    "Version=$(CalcNuGetPackageVersion 20172);Configuration=$Configuration;DependencyVer=[9.0];BinDirInclude=bin\R20172"
)
$NugetPushServer = "https://www.myget.org/F/ulrichb/api/v2/package"

Clean
PackageRestore
Build
NugetPack
Test

if ($NugetPushKey) {
    NugetPush
}
