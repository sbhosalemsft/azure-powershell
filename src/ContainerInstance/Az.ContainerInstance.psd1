#
# Module manifest for module 'Az.ContainerInstance'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2021/12/2
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './Az.ContainerInstance.psm1'

# Version number of this module.
ModuleVersion = '3.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'ddf74844-4a25-4263-8a5c-f27979292e4e'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell: ContainerInstance cmdlets'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.7.1'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = './bin/Az.ContainerInstance.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = './Az.ContainerInstance.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Add-AzContainerInstanceOutput', 'Get-AzContainerGroup', 
               'Get-AzContainerInstanceCachedImage', 
               'Get-AzContainerInstanceCapability', 
               'Get-AzContainerInstanceContainerGroupOutboundNetworkDependencyEndpoint', 
               'Get-AzContainerInstanceLog', 'Get-AzContainerInstanceUsage', 
               'Invoke-AzContainerInstanceCommand', 'New-AzContainerGroup', 
               'New-AzContainerGroupImageRegistryCredentialObject', 
               'New-AzContainerGroupPortObject', 
               'New-AzContainerGroupVolumeObject', 
               'New-AzContainerInstanceEnvironmentVariableObject', 
               'New-AzContainerInstanceHttpHeaderObject', 
               'New-AzContainerInstanceInitDefinitionObject', 
               'New-AzContainerInstanceObject', 
               'New-AzContainerInstancePortObject', 
               'New-AzContainerInstanceVolumeMountObject', 
               'Remove-AzContainerGroup', 'Restart-AzContainerGroup', 
               'Start-AzContainerGroup', 'Stop-AzContainerGroup', 
               'Update-AzContainerGroup'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Get-AzContainerGroupOutboundNetworkDependencyEndpoint'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','PSModule','ContainerInstance'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Upgraded API version to 2021-09-01
  - [Breaking Change] Changed the type of parameter ''LogAnalyticWorkspaceResourceId'' in ''New-AzContainerGroup'' from Hashtable to String
  - [Breaking Change] Removed parameter ''NetworkProfileId'' in ''New-AzContainerGroup'', added ''SubnetId'' as its alternative
  - [Breaking Change] Removed parameter ''ReadinessProbeHttpGetHttpHeadersName'' and ''ReadinessProbeHttpGetHttpHeadersValue'' in ''New-AzContainerInstanceObject'', added ''ReadinessProbeHttpGetHttpHeader'' as their alternative
  - [Breaking Change] Removed parameter ''LivenessProbeHttpGetHttpHeadersName'' and ''LivenessProbeHttpGetHttpHeadersValue'' in ''New-AzContainerInstanceObject'', added ''LivenessProbeHttpGetHttpHeader'' as their alternative
  - Added ''Zone'' in ''New-AzContainerGroup'', ''AcrIdentity'' in ''New-AzContainerGroupImageRegistryCredentialObject''
  - Changed ''Username'' in ''New-AzContainerGroupImageRegistryCredentialObject'' from mandatory to optional
* For ''Invoke-AzContainerInstanceCommand''
    - [Breaking Change] Displayed command execution result as the cmdlet output by connecting websocket in backend [#15754]
    - Added ''-PassThru'' to get last execution result when the command succeeds
    - Changed ''TerminalSizeCol'' and ''TerminalSizeRow'' from mandatory to optional, set their default values by current PowerShell window size
* Added ''Restart-AzContainerGroup'', ''Get-AzContainerInstanceContainerGroupOutboundNetworkDependencyEndpoint'' and ''New-AzContainerInstanceHttpHeaderObject'''

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

