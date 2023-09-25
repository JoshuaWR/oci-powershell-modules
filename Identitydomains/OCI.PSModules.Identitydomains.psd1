#
# Module manifest for module 'OCI.PSModules.Identitydomains'
#
# Generated by: Oracle Cloud Infrastructure
#
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'assemblies/OCI.PSModules.Identitydomains.dll'

# Version number of this module.
ModuleVersion = '67.2.0'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = 'a6c13cbd-d51d-4887-9285-9eb20c02e9cc'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'This modules provides Cmdlets for OCI Identitydomains Service'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '67.2.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'assemblies/OCI.DotNetSDK.Identitydomains.dll'

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
CmdletsToExport = 'Get-OCIIdentitydomainsAccountMgmtInfo', 
               'Get-OCIIdentitydomainsAccountMgmtInfosList', 
               'Get-OCIIdentitydomainsAccountRecoverySetting', 
               'Get-OCIIdentitydomainsAccountRecoverySettingsList', 
               'Get-OCIIdentitydomainsApiKey', 'Get-OCIIdentitydomainsApiKeysList', 
               'Get-OCIIdentitydomainsApp', 'Get-OCIIdentitydomainsAppRole', 
               'Get-OCIIdentitydomainsAppRolesList', 
               'Get-OCIIdentitydomainsAppsList', 
               'Get-OCIIdentitydomainsAuthenticationFactorSetting', 
               'Get-OCIIdentitydomainsAuthenticationFactorSettingsList', 
               'Get-OCIIdentitydomainsAuthToken', 
               'Get-OCIIdentitydomainsAuthTokensList', 
               'Get-OCIIdentitydomainsCustomerSecretKey', 
               'Get-OCIIdentitydomainsCustomerSecretKeysList', 
               'Get-OCIIdentitydomainsDynamicResourceGroup', 
               'Get-OCIIdentitydomainsDynamicResourceGroupsList', 
               'Get-OCIIdentitydomainsGrant', 'Get-OCIIdentitydomainsGrantsList', 
               'Get-OCIIdentitydomainsGroup', 'Get-OCIIdentitydomainsGroupsList', 
               'Get-OCIIdentitydomainsIdentityProvider', 
               'Get-OCIIdentitydomainsIdentityProvidersList', 
               'Get-OCIIdentitydomainsIdentitySetting', 
               'Get-OCIIdentitydomainsIdentitySettingsList', 
               'Get-OCIIdentitydomainsKmsiSetting', 
               'Get-OCIIdentitydomainsKmsiSettingsList', 
               'Get-OCIIdentitydomainsMe', 'Get-OCIIdentitydomainsMyApiKey', 
               'Get-OCIIdentitydomainsMyApiKeysList', 
               'Get-OCIIdentitydomainsMyAppsList', 
               'Get-OCIIdentitydomainsMyAuthToken', 
               'Get-OCIIdentitydomainsMyAuthTokensList', 
               'Get-OCIIdentitydomainsMyCustomerSecretKey', 
               'Get-OCIIdentitydomainsMyCustomerSecretKeysList', 
               'Get-OCIIdentitydomainsMyDevice', 
               'Get-OCIIdentitydomainsMyDevicesList', 
               'Get-OCIIdentitydomainsMyGroupsList', 
               'Get-OCIIdentitydomainsMyOAuth2ClientCredential', 
               'Get-OCIIdentitydomainsMyOAuth2ClientCredentialsList', 
               'Get-OCIIdentitydomainsMyRequestableGroupsList', 
               'Get-OCIIdentitydomainsMyRequestsList', 
               'Get-OCIIdentitydomainsMySmtpCredential', 
               'Get-OCIIdentitydomainsMySmtpCredentialsList', 
               'Get-OCIIdentitydomainsMySupportAccount', 
               'Get-OCIIdentitydomainsMySupportAccountsList', 
               'Get-OCIIdentitydomainsMyTrustedUserAgent', 
               'Get-OCIIdentitydomainsMyTrustedUserAgentsList', 
               'Get-OCIIdentitydomainsMyUserDbCredential', 
               'Get-OCIIdentitydomainsMyUserDbCredentialsList', 
               'Get-OCIIdentitydomainsOAuth2ClientCredential', 
               'Get-OCIIdentitydomainsOAuth2ClientCredentialsList', 
               'Get-OCIIdentitydomainsPasswordPoliciesList', 
               'Get-OCIIdentitydomainsPasswordPolicy', 
               'Get-OCIIdentitydomainsResourceTypeSchemaAttributesList', 
               'Get-OCIIdentitydomainsSecurityQuestion', 
               'Get-OCIIdentitydomainsSecurityQuestionSetting', 
               'Get-OCIIdentitydomainsSecurityQuestionSettingsList', 
               'Get-OCIIdentitydomainsSecurityQuestionsList', 
               'Get-OCIIdentitydomainsSmtpCredential', 
               'Get-OCIIdentitydomainsSmtpCredentialsList', 
               'Get-OCIIdentitydomainsUser', 
               'Get-OCIIdentitydomainsUserAttributesSetting', 
               'Get-OCIIdentitydomainsUserAttributesSettingsList', 
               'Get-OCIIdentitydomainsUserDbCredential', 
               'Get-OCIIdentitydomainsUserDbCredentialsList', 
               'Get-OCIIdentitydomainsUsersList', 
               'Invoke-OCIIdentitydomainsPatchAccountRecoverySetting', 
               'Invoke-OCIIdentitydomainsPatchApiKey', 
               'Invoke-OCIIdentitydomainsPatchApp', 
               'Invoke-OCIIdentitydomainsPatchAppRole', 
               'Invoke-OCIIdentitydomainsPatchAuthToken', 
               'Invoke-OCIIdentitydomainsPatchCustomerSecretKey', 
               'Invoke-OCIIdentitydomainsPatchDynamicResourceGroup', 
               'Invoke-OCIIdentitydomainsPatchGrant', 
               'Invoke-OCIIdentitydomainsPatchGroup', 
               'Invoke-OCIIdentitydomainsPatchIdentityProvider', 
               'Invoke-OCIIdentitydomainsPatchIdentitySetting', 
               'Invoke-OCIIdentitydomainsPatchKmsiSetting', 
               'Invoke-OCIIdentitydomainsPatchMe', 
               'Invoke-OCIIdentitydomainsPatchMyApiKey', 
               'Invoke-OCIIdentitydomainsPatchMyAuthToken', 
               'Invoke-OCIIdentitydomainsPatchMyCustomerSecretKey', 
               'Invoke-OCIIdentitydomainsPatchMyDevice', 
               'Invoke-OCIIdentitydomainsPatchMyOAuth2ClientCredential', 
               'Invoke-OCIIdentitydomainsPatchMySmtpCredential', 
               'Invoke-OCIIdentitydomainsPatchOAuth2ClientCredential', 
               'Invoke-OCIIdentitydomainsPatchPasswordPolicy', 
               'Invoke-OCIIdentitydomainsPatchSecurityQuestion', 
               'Invoke-OCIIdentitydomainsPatchSecurityQuestionSetting', 
               'Invoke-OCIIdentitydomainsPatchSmtpCredential', 
               'Invoke-OCIIdentitydomainsPatchUser', 
               'Invoke-OCIIdentitydomainsPatchUserAttributesSetting', 
               'Invoke-OCIIdentitydomainsSearchAccountMgmtInfos', 
               'Invoke-OCIIdentitydomainsSearchApiKeys', 
               'Invoke-OCIIdentitydomainsSearchAppRoles', 
               'Invoke-OCIIdentitydomainsSearchApps', 
               'Invoke-OCIIdentitydomainsSearchAuthenticationFactorSettings', 
               'Invoke-OCIIdentitydomainsSearchAuthTokens', 
               'Invoke-OCIIdentitydomainsSearchCustomerSecretKeys', 
               'Invoke-OCIIdentitydomainsSearchDynamicResourceGroups', 
               'Invoke-OCIIdentitydomainsSearchGrants', 
               'Invoke-OCIIdentitydomainsSearchGroups', 
               'Invoke-OCIIdentitydomainsSearchIdentityProviders', 
               'Invoke-OCIIdentitydomainsSearchIdentitySettings', 
               'Invoke-OCIIdentitydomainsSearchKmsiSettings', 
               'Invoke-OCIIdentitydomainsSearchMyApps', 
               'Invoke-OCIIdentitydomainsSearchMyGroups', 
               'Invoke-OCIIdentitydomainsSearchMyRequestableGroups', 
               'Invoke-OCIIdentitydomainsSearchMyRequests', 
               'Invoke-OCIIdentitydomainsSearchOAuth2ClientCredentials', 
               'Invoke-OCIIdentitydomainsSearchPasswordPolicies', 
               'Invoke-OCIIdentitydomainsSearchResourceTypeSchemaAttributes', 
               'Invoke-OCIIdentitydomainsSearchSecurityQuestions', 
               'Invoke-OCIIdentitydomainsSearchSecurityQuestionSettings', 
               'Invoke-OCIIdentitydomainsSearchSmtpCredentials', 
               'Invoke-OCIIdentitydomainsSearchUserAttributesSettings', 
               'Invoke-OCIIdentitydomainsSearchUserDbCredentials', 
               'Invoke-OCIIdentitydomainsSearchUsers', 
               'New-OCIIdentitydomainsApiKey', 'New-OCIIdentitydomainsApp', 
               'New-OCIIdentitydomainsAppRole', 
               'New-OCIIdentitydomainsAuthenticationFactorsRemover', 
               'New-OCIIdentitydomainsAuthToken', 
               'New-OCIIdentitydomainsCustomerSecretKey', 
               'New-OCIIdentitydomainsDynamicResourceGroup', 
               'New-OCIIdentitydomainsGrant', 'New-OCIIdentitydomainsGroup', 
               'New-OCIIdentitydomainsIdentityProvider', 
               'New-OCIIdentitydomainsMe', 'New-OCIIdentitydomainsMyApiKey', 
               'New-OCIIdentitydomainsMyAuthenticationFactorInitiator', 
               'New-OCIIdentitydomainsMyAuthenticationFactorsRemover', 
               'New-OCIIdentitydomainsMyAuthenticationFactorValidator', 
               'New-OCIIdentitydomainsMyAuthToken', 
               'New-OCIIdentitydomainsMyCustomerSecretKey', 
               'New-OCIIdentitydomainsMyOAuth2ClientCredential', 
               'New-OCIIdentitydomainsMyRequest', 
               'New-OCIIdentitydomainsMySmtpCredential', 
               'New-OCIIdentitydomainsMySupportAccount', 
               'New-OCIIdentitydomainsMyUserDbCredential', 
               'New-OCIIdentitydomainsOAuth2ClientCredential', 
               'New-OCIIdentitydomainsPasswordPolicy', 
               'New-OCIIdentitydomainsSecurityQuestion', 
               'New-OCIIdentitydomainsSmtpCredential', 
               'New-OCIIdentitydomainsUser', 
               'New-OCIIdentitydomainsUserDbCredential', 
               'Remove-OCIIdentitydomainsApiKey', 'Remove-OCIIdentitydomainsApp', 
               'Remove-OCIIdentitydomainsAppRole', 
               'Remove-OCIIdentitydomainsAuthToken', 
               'Remove-OCIIdentitydomainsCustomerSecretKey', 
               'Remove-OCIIdentitydomainsDynamicResourceGroup', 
               'Remove-OCIIdentitydomainsGrant', 'Remove-OCIIdentitydomainsGroup', 
               'Remove-OCIIdentitydomainsIdentityProvider', 
               'Remove-OCIIdentitydomainsMyApiKey', 
               'Remove-OCIIdentitydomainsMyAuthToken', 
               'Remove-OCIIdentitydomainsMyCustomerSecretKey', 
               'Remove-OCIIdentitydomainsMyDevice', 
               'Remove-OCIIdentitydomainsMyOAuth2ClientCredential', 
               'Remove-OCIIdentitydomainsMySmtpCredential', 
               'Remove-OCIIdentitydomainsMySupportAccount', 
               'Remove-OCIIdentitydomainsMyTrustedUserAgent', 
               'Remove-OCIIdentitydomainsMyUserDbCredential', 
               'Remove-OCIIdentitydomainsOAuth2ClientCredential', 
               'Remove-OCIIdentitydomainsPasswordPolicy', 
               'Remove-OCIIdentitydomainsSecurityQuestion', 
               'Remove-OCIIdentitydomainsSmtpCredential', 
               'Remove-OCIIdentitydomainsUser', 
               'Remove-OCIIdentitydomainsUserDbCredential', 
               'Write-OCIIdentitydomainsAccountRecoverySetting', 
               'Write-OCIIdentitydomainsApp', 
               'Write-OCIIdentitydomainsAppStatusChanger', 
               'Write-OCIIdentitydomainsAuthenticationFactorSetting', 
               'Write-OCIIdentitydomainsDynamicResourceGroup', 
               'Write-OCIIdentitydomainsGroup', 
               'Write-OCIIdentitydomainsIdentityProvider', 
               'Write-OCIIdentitydomainsIdentitySetting', 
               'Write-OCIIdentitydomainsKmsiSetting', 'Write-OCIIdentitydomainsMe', 
               'Write-OCIIdentitydomainsMePasswordChanger', 
               'Write-OCIIdentitydomainsPasswordPolicy', 
               'Write-OCIIdentitydomainsSecurityQuestionSetting', 
               'Write-OCIIdentitydomainsUser', 
               'Write-OCIIdentitydomainsUserCapabilitiesChanger', 
               'Write-OCIIdentitydomainsUserPasswordChanger', 
               'Write-OCIIdentitydomainsUserPasswordResetter', 
               'Write-OCIIdentitydomainsUserStatusChanger'

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
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure','Identitydomains'

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

