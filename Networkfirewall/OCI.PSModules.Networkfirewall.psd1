#
# Module manifest for module 'OCI.PSModules.Networkfirewall'
#
# Generated by: Oracle Cloud Infrastructure
#
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'assemblies/OCI.PSModules.Networkfirewall.dll'

# Version number of this module.
ModuleVersion = '94.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = '6a784c1a-dca2-489e-beb9-d910537df35b'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'This modules provides Cmdlets for OCI Networkfirewall Service'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '94.1.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'assemblies/OCI.DotNetSDK.Networkfirewall.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = '*'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Get-OCINetworkfirewall', 'Get-OCINetworkfirewallAddressList', 
               'Get-OCINetworkfirewallAddressListsList', 
               'Get-OCINetworkfirewallApplication', 
               'Get-OCINetworkfirewallApplicationGroup', 
               'Get-OCINetworkfirewallApplicationGroupsList', 
               'Get-OCINetworkfirewallApplicationsList', 
               'Get-OCINetworkfirewallDecryptionProfile', 
               'Get-OCINetworkfirewallDecryptionProfilesList', 
               'Get-OCINetworkfirewallDecryptionRule', 
               'Get-OCINetworkfirewallDecryptionRulesList', 
               'Get-OCINetworkfirewallMappedSecret', 
               'Get-OCINetworkfirewallMappedSecretsList', 
               'Get-OCINetworkfirewallPoliciesList', 
               'Get-OCINetworkfirewallPolicy', 
               'Get-OCINetworkfirewallSecurityRule', 
               'Get-OCINetworkfirewallSecurityRulesList', 
               'Get-OCINetworkfirewallService', 
               'Get-OCINetworkfirewallServiceList', 
               'Get-OCINetworkfirewallServiceListsList', 
               'Get-OCINetworkfirewallServicesList', 'Get-OCINetworkfirewallsList', 
               'Get-OCINetworkfirewallTunnelInspectionRule', 
               'Get-OCINetworkfirewallTunnelInspectionRulesList', 
               'Get-OCINetworkfirewallUrlList', 
               'Get-OCINetworkfirewallUrlListsList', 
               'Get-OCINetworkfirewallWorkRequest', 
               'Get-OCINetworkfirewallWorkRequestErrorsList', 
               'Get-OCINetworkfirewallWorkRequestLogsList', 
               'Get-OCINetworkfirewallWorkRequestsList', 
               'Invoke-OCINetworkfirewallApplyNetworkFirewallPolicy', 
               'Invoke-OCINetworkfirewallBulkUploadAddressLists', 
               'Invoke-OCINetworkfirewallBulkUploadApplicationGroups', 
               'Invoke-OCINetworkfirewallBulkUploadApplications', 
               'Invoke-OCINetworkfirewallBulkUploadDecryptionProfiles', 
               'Invoke-OCINetworkfirewallBulkUploadDecryptionRules', 
               'Invoke-OCINetworkfirewallBulkUploadMappedSecrets', 
               'Invoke-OCINetworkfirewallBulkUploadSecurityRules', 
               'Invoke-OCINetworkfirewallBulkUploadServiceLists', 
               'Invoke-OCINetworkfirewallBulkUploadServices', 
               'Invoke-OCINetworkfirewallBulkUploadTunnelInspectionRules', 
               'Invoke-OCINetworkfirewallBulkUploadUrlLists', 
               'Invoke-OCINetworkfirewallCloneNetworkFirewallPolicy', 
               'Invoke-OCINetworkfirewallMigrateNetworkFirewallPolicy', 
               'Move-OCINetworkfirewallCompartment', 
               'Move-OCINetworkfirewallPolicyCompartment', 
               'New-OCINetworkfirewall', 'New-OCINetworkfirewallAddressList', 
               'New-OCINetworkfirewallApplication', 
               'New-OCINetworkfirewallApplicationGroup', 
               'New-OCINetworkfirewallDecryptionProfile', 
               'New-OCINetworkfirewallDecryptionRule', 
               'New-OCINetworkfirewallMappedSecret', 
               'New-OCINetworkfirewallPolicy', 
               'New-OCINetworkfirewallSecurityRule', 
               'New-OCINetworkfirewallService', 
               'New-OCINetworkfirewallServiceList', 
               'New-OCINetworkfirewallTunnelInspectionRule', 
               'New-OCINetworkfirewallUrlList', 'Remove-OCINetworkfirewall', 
               'Remove-OCINetworkfirewallAddressList', 
               'Remove-OCINetworkfirewallApplication', 
               'Remove-OCINetworkfirewallApplicationGroup', 
               'Remove-OCINetworkfirewallDecryptionProfile', 
               'Remove-OCINetworkfirewallDecryptionRule', 
               'Remove-OCINetworkfirewallMappedSecret', 
               'Remove-OCINetworkfirewallPolicy', 
               'Remove-OCINetworkfirewallSecurityRule', 
               'Remove-OCINetworkfirewallService', 
               'Remove-OCINetworkfirewallServiceList', 
               'Remove-OCINetworkfirewallTunnelInspectionRule', 
               'Remove-OCINetworkfirewallUrlList', 
               'Stop-OCINetworkfirewallWorkRequest', 'Update-OCINetworkfirewall', 
               'Update-OCINetworkfirewallAddressList', 
               'Update-OCINetworkfirewallApplication', 
               'Update-OCINetworkfirewallApplicationGroup', 
               'Update-OCINetworkfirewallDecryptionProfile', 
               'Update-OCINetworkfirewallDecryptionRule', 
               'Update-OCINetworkfirewallMappedSecret', 
               'Update-OCINetworkfirewallPolicy', 
               'Update-OCINetworkfirewallSecurityRule', 
               'Update-OCINetworkfirewallService', 
               'Update-OCINetworkfirewallServiceList', 
               'Update-OCINetworkfirewallTunnelInspectionRule', 
               'Update-OCINetworkfirewallUrlList'

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

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
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure','Networkfirewall'

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

