#
# Module manifest for module 'OCI.PSModules'
#
# Generated by: Manually by L. Waters - This needs to be automated into the release process!
#
# Generated on: 12/08/2020
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '3.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '5ee167f1-0abc-4d85-b9b3-6d354fcaaa35'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Oracle Cloud Infrastructure (OCI) PowerShell Modules - Cmdlets to manage resources in OCI.
For more information, please visit: https://docs.cloud.oracle.com/en-us/iaas/Content/API/SDKDocs/powershell.htm'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '6.0'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = ''

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# EXCLUDES: OCI.PSModules.Examples, OCI.PSModules.Tests
RequiredModules =  @(
	@{'OCI.PSModules.Analytics'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Announcementsservice'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Apigateway'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Applicationmigration'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Audit'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Autoscaling'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Bds'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Blockchain'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Budget'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Cims'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Cloudguard'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Common'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Computeinstanceagent'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Containerengine'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Core'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Database'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Datacatalog'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Dataflow'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Dataintegration'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Datasafe'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Datascience'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Dns'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Dts'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Email'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Events'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Filestorage'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Functions'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Healthchecks'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Identity'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Integration'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Keymanagement'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Limits'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Loadbalancer'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Loganalytics'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Logging'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Loggingingestion'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Loggingsearch'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Managementagent'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Managementdashboard'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Marketplace'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Monitoring'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Mysql'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Nosql'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Objectstorage'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Oce'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Ocvp'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Oda'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Ons'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Opsi'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Optimizer'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Osmanagement'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Resourcemanager'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Resourcesearch'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Sch'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Secrets'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Streaming'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Tenantmanagercontrolplane'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Usageapi'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Vault'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Waas'; ModuleVersion = '3.0.0'; },
	@{'OCI.PSModules.Workrequests'; ModuleVersion = '3.0.0'; }
)

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = ''

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = '*'

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

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
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure'

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/oracle/oci-powershell-modules/blob/master/LICENSE.txt'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/oracle/oci-powershell-modules/'

        # A URL to an icon representing this module.
        IconUri = 'https://github.com/oracle/oci-powershell-modules/blob/master/icon.png'

        # ReleaseNotes of this module
        ReleaseNotes = 'https://github.com/oracle/oci-powershell-modules/blob/master/CHANGELOG.md'

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

