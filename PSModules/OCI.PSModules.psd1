#
# Module manifest for module 'OCI.PSModules'
#
# Generated by: Oracle Cloud Infrastructure
#
# Generated on: 6/21/2021
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '15.1.0'

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
For more information, please visit: https://docs.oracle.com/en-us/iaas/Content/API/SDKDocs/powershell.htm'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Ailanguage'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Analytics'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Announcementsservice'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Apigateway'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Apmcontrolplane'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Apmsynthetics'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Apmtraces'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Applicationmigration'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Artifacts'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Audit'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Autoscaling'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Bastion'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Bds'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Blockchain'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Budget'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Cims'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Cloudguard'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Computeinstanceagent'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Containerengine'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Core'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Database'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Databasemanagement'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Databasemigration'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Datacatalog'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Dataflow'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Dataintegration'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Datasafe'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Datascience'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Dns'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Dts'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Email'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Events'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Filestorage'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Functions'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Genericartifactscontent'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Goldengate'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Healthchecks'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Identity'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Integration'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Jms'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Keymanagement'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Limits'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Loadbalancer'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Loganalytics'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Logging'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Loggingingestion'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Loggingsearch'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Managementagent'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Managementdashboard'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Marketplace'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Monitoring'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Mysql'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Networkloadbalancer'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Nosql'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Objectstorage'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Oce'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Ocvp'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Oda'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Ons'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Operatoraccesscontrol'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Opsi'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Optimizer'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Osmanagement'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Resourcemanager'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Resourcesearch'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Rover'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Sch'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Secrets'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Servicecatalog'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Streaming'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Tenantmanagercontrolplane'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Usageapi'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Vault'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Vulnerabilityscanning'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Waas'; RequiredVersion = '15.1.0'; }, 
               @{ModuleName = 'OCI.PSModules.Workrequests'; RequiredVersion = '15.1.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

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

