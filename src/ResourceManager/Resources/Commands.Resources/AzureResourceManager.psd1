﻿#  
# Module manifest for module 'Azure Resource Manager'  
#  
# Generated by: Microsoft Corporation  
#  
# Generated on: 4/01/2014  
#  
  
@{  
  
# Version number of this module.  
ModuleVersion = '1.2.2' 
  
# ID used to uniquely identify this module  
GUID = '81d522a4-6e5d-4105-8f58-376204c47458'  
  
# Author of this module  
Author = 'Microsoft Corporation'  
  
# Company or vendor of this module  
CompanyName = 'Microsoft Corporation'  
  
# Copyright statement for this module  
Copyright = 'Microsoft Corporation. All rights reserved.'    
  
# Description of the functionality provided by this module  
Description = 'Azure Resource Manager'  
  
# Minimum version of the Windows PowerShell engine required by this module  
PowerShellVersion = '3.0'  
  
# Name of the Windows PowerShell host required by this module  
PowerShellHostName = ''  
  
# Minimum version of the Windows PowerShell host required by this module  
PowerShellHostVersion = ''  
  
# Minimum version of the .NET Framework required by this module  
DotNetFrameworkVersion = '4.0'  
  
# Minimum version of the common language runtime (CLR) required by this module  
CLRVersion='4.0'  
  
# Processor architecture (None, X86, Amd64, IA64) required by this module  
ProcessorArchitecture = 'None'  
  
# Modules that must be imported into the global environment prior to importing this module  
RequiredModules = @()  
  
# Assemblies that must be loaded prior to importing this module  
RequiredAssemblies = @()  
  
# Script files (.ps1) that are run in the caller's environment prior to importing this module  
ScriptsToProcess = @()  
  
# Type files (.ps1xml) to be loaded when importing this module  
TypesToProcess = @(  
    '.\AzureRM.Compute\Microsoft.Azure.Commands.Compute.Types.ps1xml',
    '.\AzureRM.Sql\Microsoft.Azure.Commands.Sql.Types.ps1xml',
    '.\Azure.Storage\Microsoft.WindowsAzure.Commands.Storage.Types.ps1xml',
    '.\AzureRM.Resources\Microsoft.Azure.Commands.ResourceManager.Cmdlets.Types.ps1xml'
)  
  
# Format files (.ps1xml) to be loaded when importing this module  
FormatsToProcess = @(  
    '.\AzureRM.Resources\Microsoft.Azure.Commands.Resources.format.ps1xml',
    '.\AzureRM.Resources\Microsoft.Azure.Commands.ResourceManager.Cmdlets.format.ps1xml',
    '.\AzureRM.Tags\Microsoft.Azure.Commands.Tags.format.ps1xml',  
    '.\AzureRM.Profile\Microsoft.Azure.Commands.Profile.format.ps1xml',
    '.\AzureRM.DataFactories\Microsoft.Azure.Commands.DataFactories.format.ps1xml',  
    '.\AzureRM.RedisCache\Microsoft.Azure.Commands.RedisCache.format.ps1xml',  
    '.\AzureRM.Batch\Microsoft.Azure.Commands.Batch.format.ps1xml',  
    '.\AzureRM.KeyVault\Microsoft.Azure.Commands.KeyVault.format.ps1xml',  
    '.\AzureRM.StreamAnalytics\Microsoft.Azure.Commands.StreamAnalytics.format.ps1xml',  
    '.\AzureRM.Compute\Microsoft.Azure.Commands.Compute.format.ps1xml',  
    '.\AzureRM.Compute\Microsoft.Azure.Commands.Compute.format.generated.ps1xml',  
    '.\AzureRM.Network\Microsoft.Azure.Commands.Network.format.ps1xml',  
    '.\Azure.Storage\Microsoft.WindowsAzure.Commands.Storage.format.ps1xml',
    '.\AzureRM.Storage\Microsoft.Azure.Commands.Management.Storage.format.ps1xml', 
    '.\AzureRM.OperationalInsights\Microsoft.Azure.Commands.OperationalInsights.format.ps1xml',  
    '.\AzureRM.Backup\Microsoft.Azure.Commands.AzureBackup.format.ps1xml',
    '.\AzureRM.UsageAggregates\Microsoft.Azure.Commands.UsageAggregates.Format.ps1xml',
    '.\AzureRM.Sql\Microsoft.Azure.Commands.Sql.format.ps1xml',
	'.\AzureRM.DataLakeAnalytics\Microsoft.Azure.Commands.DataLakeAnalytics.format.ps1xml',
	'.\AzureRM.DataLakeStore\Microsoft.Azure.Commands.DataLakeStoreFileSystem.format.ps1xml'
)  
  
# Modules to import as nested modules of the module specified in ModuleToProcess  
NestedModules = @(  
    '.\AzureRM.Profile',
    '.\AzureRM.Automation',
    '.\AzureRM.Resources\AzureRM.Resources.psd1',
    '.\AzureRM.Resources\AzureRM.Tags.psd1',
    '.\AzureRM.Tags',  
    '.\AzureRM.Sql',  
    '.\AzureRM.DataFactories',  
    '.\AzureRM.RedisCache',  
    '.\AzureRM.Batch',  
    '.\AzureRM.Dns',  
    '.\AzureRM.KeyVault',  
    '.\AzureRM.TrafficManager',  
    '.\AzureRM.StreamAnalytics',  
    '.\AzureRM.Insights',  
    '.\AzureRM.Websites',  
    '.\AzureRM.Compute',  
    '.\AzureRM.Network',  
    '.\Azure.Storage',
    '.\AzureRM.ApiManagement',  
    '.\AzureRM.Storage',  
    '.\AzureRM.OperationalInsights',  
    '.\AzureRM.UsageAggregates', 
    '.\AzureRM.HDInsight',
    '.\AzureRM.ApiManagement',  
    '.\AzureRM.Backup',
    '.\AzureRM.SiteRecovery',
    '.\AzureRM.DataLakeAnalytics',
    '.\AzureRM.DataLakeStore',
    '.\AzureRM.Intune',
    '.\AzureRM.RecoveryServices',
	'.\AzureRM.RecoveryServices.Backup',
    '.\AzureRM.AzureStackAdmin',
    '.\AzureRM.AzureStackStorage'
)  
  
# Functions to export from this module  
FunctionsToExport = '*'  
  
# Cmdlets to export from this module  
CmdletsToExport = '*'  
  
# Variables to export from this module  
VariablesToExport = '*'  
  
# Aliases to export from this module  
AliasesToExport = '*'
  
# List of all modules packaged with this module  
ModuleList = @()  
  
# List of all files packaged with this module  
FileList =  @()  
  
# Private data to pass to the module specified in ModuleToProcess  
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        # Tags = @()

        # A URL to the license for this module.
        LicenseUri = 'https://raw.githubusercontent.com/Azure/azure-powershell/dev/LICENSE.txt'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = 'https://github.com/Azure/azure-powershell/blob/dev/ChangeLog.md'

    } # End of PSData hashtable

} # End of PrivateData hashtable  

} 
