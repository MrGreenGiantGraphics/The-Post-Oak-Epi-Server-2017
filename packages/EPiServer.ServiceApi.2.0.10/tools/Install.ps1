param($installPath, $toolsPath, $package, $project)

Import-Module (Join-Path $toolsPath "Get-ConfigPath.psm1")
Import-Module (Join-Path $toolsPath "Get-Config.psm1")
Import-Module (Join-Path $toolsPath "Get-PackagesToolPath.psm1")
Import-Module (Join-Path $toolsPath "Update-AssemblyBinding.psm1")

#Get the Framework package
$frameworkPackage = Get-Package -ProjectName $project.ProjectName | Where-Object { $_.id -eq "EPiServer.Framework"} | Sort-Object -Property Version -Descending | Select-Object -First 1
$frameWorkToolPath = Get-PackagesToolPath $installPath "EPiServer.Framework" $frameworkPackage.Version
$deployEXEPath =  Join-Path ($frameWorkToolPath) "epideploy.exe"
$configUpdatePath = Join-Path $toolsPath "webconfig-update.config"
$projectFilePath = Get-ChildItem $project.Fullname
$sitePath = $projectFilePath.Directory.FullName

#add/update binding redirects for assemblies in the current package
$configPath = Get-ConfigPath $project
if ($configPath -eq $null)
{
	Write-Host "Unable to find a configuration file, binding redirect not configured."
}
else
{
	$config = Get-Config $configPath
    Update-AssemblyBinding $config $installPath | Out-Null
	$config.Save($configPath)

	Write-Host "Update ServiceApi configuration"
	$config = Get-Config $configPath
    & $deployEXEPath -s $sitePath -a config -p $configUpdatePath
}