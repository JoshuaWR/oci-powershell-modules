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
ModuleVersion = '89.0.0'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '89.0.0'; })

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
               'Get-OCIIdentitydomainsApprovalWorkflow', 
               'Get-OCIIdentitydomainsApprovalWorkflowAssignment', 
               'Get-OCIIdentitydomainsApprovalWorkflowAssignmentsList', 
               'Get-OCIIdentitydomainsApprovalWorkflowsList', 
               'Get-OCIIdentitydomainsApprovalWorkflowStep', 
               'Get-OCIIdentitydomainsApprovalWorkflowStepsList', 
               'Get-OCIIdentitydomainsAppsList', 
               'Get-OCIIdentitydomainsAuthenticationFactorSetting', 
               'Get-OCIIdentitydomainsAuthenticationFactorSettingsList', 
               'Get-OCIIdentitydomainsAuthToken', 
               'Get-OCIIdentitydomainsAuthTokensList', 
               'Get-OCIIdentitydomainsBrandingSetting', 
               'Get-OCIIdentitydomainsBrandingSettingsList', 
               'Get-OCIIdentitydomainsCloudGate', 
               'Get-OCIIdentitydomainsCloudGateMapping', 
               'Get-OCIIdentitydomainsCloudGateMappingsList', 
               'Get-OCIIdentitydomainsCloudGateServer', 
               'Get-OCIIdentitydomainsCloudGateServersList', 
               'Get-OCIIdentitydomainsCloudGatesList', 
               'Get-OCIIdentitydomainsCondition', 
               'Get-OCIIdentitydomainsConditionsList', 
               'Get-OCIIdentitydomainsCustomerSecretKey', 
               'Get-OCIIdentitydomainsCustomerSecretKeysList', 
               'Get-OCIIdentitydomainsDynamicResourceGroup', 
               'Get-OCIIdentitydomainsDynamicResourceGroupsList', 
               'Get-OCIIdentitydomainsGrant', 'Get-OCIIdentitydomainsGrantsList', 
               'Get-OCIIdentitydomainsGroup', 'Get-OCIIdentitydomainsGroupsList', 
               'Get-OCIIdentitydomainsIdentityPropagationTrust', 
               'Get-OCIIdentitydomainsIdentityPropagationTrustsList', 
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
               'Get-OCIIdentitydomainsMyCompletedApproval', 
               'Get-OCIIdentitydomainsMyCompletedApprovalsList', 
               'Get-OCIIdentitydomainsMyCustomerSecretKey', 
               'Get-OCIIdentitydomainsMyCustomerSecretKeysList', 
               'Get-OCIIdentitydomainsMyDevice', 
               'Get-OCIIdentitydomainsMyDevicesList', 
               'Get-OCIIdentitydomainsMyGroupsList', 
               'Get-OCIIdentitydomainsMyOAuth2ClientCredential', 
               'Get-OCIIdentitydomainsMyOAuth2ClientCredentialsList', 
               'Get-OCIIdentitydomainsMyPendingApproval', 
               'Get-OCIIdentitydomainsMyPendingApprovalsList', 
               'Get-OCIIdentitydomainsMyRequest', 
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
               'Get-OCIIdentitydomainsNetworkPerimeter', 
               'Get-OCIIdentitydomainsNetworkPerimetersList', 
               'Get-OCIIdentitydomainsNotificationSetting', 
               'Get-OCIIdentitydomainsNotificationSettingsList', 
               'Get-OCIIdentitydomainsOAuth2ClientCredential', 
               'Get-OCIIdentitydomainsOAuth2ClientCredentialsList', 
               'Get-OCIIdentitydomainsOAuthClientCertificate', 
               'Get-OCIIdentitydomainsOAuthClientCertificatesList', 
               'Get-OCIIdentitydomainsOAuthPartnerCertificate', 
               'Get-OCIIdentitydomainsOAuthPartnerCertificatesList', 
               'Get-OCIIdentitydomainsPasswordPoliciesList', 
               'Get-OCIIdentitydomainsPasswordPolicy', 
               'Get-OCIIdentitydomainsPoliciesList', 
               'Get-OCIIdentitydomainsPolicy', 
               'Get-OCIIdentitydomainsResourceTypeSchemaAttributesList', 
               'Get-OCIIdentitydomainsRule', 'Get-OCIIdentitydomainsRulesList', 
               'Get-OCIIdentitydomainsSchema', 'Get-OCIIdentitydomainsSchemasList', 
               'Get-OCIIdentitydomainsSecurityQuestion', 
               'Get-OCIIdentitydomainsSecurityQuestionSetting', 
               'Get-OCIIdentitydomainsSecurityQuestionSettingsList', 
               'Get-OCIIdentitydomainsSecurityQuestionsList', 
               'Get-OCIIdentitydomainsSelfRegistrationProfile', 
               'Get-OCIIdentitydomainsSelfRegistrationProfilesList', 
               'Get-OCIIdentitydomainsSetting', 
               'Get-OCIIdentitydomainsSettingsList', 
               'Get-OCIIdentitydomainsSmtpCredential', 
               'Get-OCIIdentitydomainsSmtpCredentialsList', 
               'Get-OCIIdentitydomainsSocialIdentityProvider', 
               'Get-OCIIdentitydomainsSocialIdentityProvidersList', 
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
               'Invoke-OCIIdentitydomainsPatchApprovalWorkflow', 
               'Invoke-OCIIdentitydomainsPatchApprovalWorkflowStep', 
               'Invoke-OCIIdentitydomainsPatchAuthToken', 
               'Invoke-OCIIdentitydomainsPatchCloudGate', 
               'Invoke-OCIIdentitydomainsPatchCloudGateMapping', 
               'Invoke-OCIIdentitydomainsPatchCloudGateServer', 
               'Invoke-OCIIdentitydomainsPatchCondition', 
               'Invoke-OCIIdentitydomainsPatchCustomerSecretKey', 
               'Invoke-OCIIdentitydomainsPatchDynamicResourceGroup', 
               'Invoke-OCIIdentitydomainsPatchGrant', 
               'Invoke-OCIIdentitydomainsPatchGroup', 
               'Invoke-OCIIdentitydomainsPatchIdentityPropagationTrust', 
               'Invoke-OCIIdentitydomainsPatchIdentityProvider', 
               'Invoke-OCIIdentitydomainsPatchIdentitySetting', 
               'Invoke-OCIIdentitydomainsPatchKmsiSetting', 
               'Invoke-OCIIdentitydomainsPatchMe', 
               'Invoke-OCIIdentitydomainsPatchMyApiKey', 
               'Invoke-OCIIdentitydomainsPatchMyAuthToken', 
               'Invoke-OCIIdentitydomainsPatchMyCustomerSecretKey', 
               'Invoke-OCIIdentitydomainsPatchMyDevice', 
               'Invoke-OCIIdentitydomainsPatchMyOAuth2ClientCredential', 
               'Invoke-OCIIdentitydomainsPatchMyPendingApproval', 
               'Invoke-OCIIdentitydomainsPatchMyRequest', 
               'Invoke-OCIIdentitydomainsPatchMySmtpCredential', 
               'Invoke-OCIIdentitydomainsPatchNetworkPerimeter', 
               'Invoke-OCIIdentitydomainsPatchOAuth2ClientCredential', 
               'Invoke-OCIIdentitydomainsPatchPasswordPolicy', 
               'Invoke-OCIIdentitydomainsPatchPolicy', 
               'Invoke-OCIIdentitydomainsPatchRule', 
               'Invoke-OCIIdentitydomainsPatchSchema', 
               'Invoke-OCIIdentitydomainsPatchSecurityQuestion', 
               'Invoke-OCIIdentitydomainsPatchSecurityQuestionSetting', 
               'Invoke-OCIIdentitydomainsPatchSelfRegistrationProfile', 
               'Invoke-OCIIdentitydomainsPatchSetting', 
               'Invoke-OCIIdentitydomainsPatchSmtpCredential', 
               'Invoke-OCIIdentitydomainsPatchSocialIdentityProvider', 
               'Invoke-OCIIdentitydomainsPatchUser', 
               'Invoke-OCIIdentitydomainsPatchUserAttributesSetting', 
               'Invoke-OCIIdentitydomainsSearchAccountMgmtInfos', 
               'Invoke-OCIIdentitydomainsSearchApiKeys', 
               'Invoke-OCIIdentitydomainsSearchAppRoles', 
               'Invoke-OCIIdentitydomainsSearchApps', 
               'Invoke-OCIIdentitydomainsSearchAuthenticationFactorSettings', 
               'Invoke-OCIIdentitydomainsSearchAuthTokens', 
               'Invoke-OCIIdentitydomainsSearchCloudGateMappings', 
               'Invoke-OCIIdentitydomainsSearchCloudGates', 
               'Invoke-OCIIdentitydomainsSearchCloudGateServers', 
               'Invoke-OCIIdentitydomainsSearchConditions', 
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
               'Invoke-OCIIdentitydomainsSearchNetworkPerimeters', 
               'Invoke-OCIIdentitydomainsSearchNotificationSettings', 
               'Invoke-OCIIdentitydomainsSearchOAuth2ClientCredentials', 
               'Invoke-OCIIdentitydomainsSearchOAuthClientCertificates', 
               'Invoke-OCIIdentitydomainsSearchOAuthPartnerCertificates', 
               'Invoke-OCIIdentitydomainsSearchPasswordPolicies', 
               'Invoke-OCIIdentitydomainsSearchPolicies', 
               'Invoke-OCIIdentitydomainsSearchResourceTypeSchemaAttributes', 
               'Invoke-OCIIdentitydomainsSearchRules', 
               'Invoke-OCIIdentitydomainsSearchSchemas', 
               'Invoke-OCIIdentitydomainsSearchSecurityQuestions', 
               'Invoke-OCIIdentitydomainsSearchSecurityQuestionSettings', 
               'Invoke-OCIIdentitydomainsSearchSelfRegistrationProfiles', 
               'Invoke-OCIIdentitydomainsSearchSettings', 
               'Invoke-OCIIdentitydomainsSearchSmtpCredentials', 
               'Invoke-OCIIdentitydomainsSearchSocialIdentityProviders', 
               'Invoke-OCIIdentitydomainsSearchUserAttributesSettings', 
               'Invoke-OCIIdentitydomainsSearchUserDbCredentials', 
               'Invoke-OCIIdentitydomainsSearchUsers', 
               'New-OCIIdentitydomainsApiKey', 'New-OCIIdentitydomainsApp', 
               'New-OCIIdentitydomainsAppRole', 
               'New-OCIIdentitydomainsApprovalWorkflow', 
               'New-OCIIdentitydomainsApprovalWorkflowAssignment', 
               'New-OCIIdentitydomainsApprovalWorkflowStep', 
               'New-OCIIdentitydomainsAuthenticationFactorsRemover', 
               'New-OCIIdentitydomainsAuthToken', 
               'New-OCIIdentitydomainsCloudGate', 
               'New-OCIIdentitydomainsCloudGateMapping', 
               'New-OCIIdentitydomainsCloudGateServer', 
               'New-OCIIdentitydomainsCondition', 
               'New-OCIIdentitydomainsCustomerSecretKey', 
               'New-OCIIdentitydomainsDynamicResourceGroup', 
               'New-OCIIdentitydomainsGrant', 'New-OCIIdentitydomainsGroup', 
               'New-OCIIdentitydomainsIdentityPropagationTrust', 
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
               'New-OCIIdentitydomainsNetworkPerimeter', 
               'New-OCIIdentitydomainsOAuth2ClientCredential', 
               'New-OCIIdentitydomainsOAuthClientCertificate', 
               'New-OCIIdentitydomainsOAuthPartnerCertificate', 
               'New-OCIIdentitydomainsPasswordPolicy', 
               'New-OCIIdentitydomainsPolicy', 'New-OCIIdentitydomainsRule', 
               'New-OCIIdentitydomainsSecurityQuestion', 
               'New-OCIIdentitydomainsSelfRegistrationProfile', 
               'New-OCIIdentitydomainsSmtpCredential', 
               'New-OCIIdentitydomainsSocialIdentityProvider', 
               'New-OCIIdentitydomainsUser', 
               'New-OCIIdentitydomainsUserDbCredential', 
               'Remove-OCIIdentitydomainsApiKey', 'Remove-OCIIdentitydomainsApp', 
               'Remove-OCIIdentitydomainsAppRole', 
               'Remove-OCIIdentitydomainsApprovalWorkflow', 
               'Remove-OCIIdentitydomainsApprovalWorkflowAssignment', 
               'Remove-OCIIdentitydomainsApprovalWorkflowStep', 
               'Remove-OCIIdentitydomainsAuthToken', 
               'Remove-OCIIdentitydomainsCloudGate', 
               'Remove-OCIIdentitydomainsCloudGateMapping', 
               'Remove-OCIIdentitydomainsCloudGateServer', 
               'Remove-OCIIdentitydomainsCondition', 
               'Remove-OCIIdentitydomainsCustomerSecretKey', 
               'Remove-OCIIdentitydomainsDynamicResourceGroup', 
               'Remove-OCIIdentitydomainsGrant', 'Remove-OCIIdentitydomainsGroup', 
               'Remove-OCIIdentitydomainsIdentityPropagationTrust', 
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
               'Remove-OCIIdentitydomainsNetworkPerimeter', 
               'Remove-OCIIdentitydomainsOAuth2ClientCredential', 
               'Remove-OCIIdentitydomainsOAuthClientCertificate', 
               'Remove-OCIIdentitydomainsOAuthPartnerCertificate', 
               'Remove-OCIIdentitydomainsPasswordPolicy', 
               'Remove-OCIIdentitydomainsPolicy', 'Remove-OCIIdentitydomainsRule', 
               'Remove-OCIIdentitydomainsSecurityQuestion', 
               'Remove-OCIIdentitydomainsSelfRegistrationProfile', 
               'Remove-OCIIdentitydomainsSmtpCredential', 
               'Remove-OCIIdentitydomainsSocialIdentityProvider', 
               'Remove-OCIIdentitydomainsUser', 
               'Remove-OCIIdentitydomainsUserDbCredential', 
               'Write-OCIIdentitydomainsAccountRecoverySetting', 
               'Write-OCIIdentitydomainsApp', 
               'Write-OCIIdentitydomainsApprovalWorkflow', 
               'Write-OCIIdentitydomainsAppStatusChanger', 
               'Write-OCIIdentitydomainsAuthenticationFactorSetting', 
               'Write-OCIIdentitydomainsCloudGate', 
               'Write-OCIIdentitydomainsCloudGateMapping', 
               'Write-OCIIdentitydomainsCloudGateServer', 
               'Write-OCIIdentitydomainsCondition', 
               'Write-OCIIdentitydomainsDynamicResourceGroup', 
               'Write-OCIIdentitydomainsGroup', 
               'Write-OCIIdentitydomainsIdentityPropagationTrust', 
               'Write-OCIIdentitydomainsIdentityProvider', 
               'Write-OCIIdentitydomainsIdentitySetting', 
               'Write-OCIIdentitydomainsKmsiSetting', 'Write-OCIIdentitydomainsMe', 
               'Write-OCIIdentitydomainsMePasswordChanger', 
               'Write-OCIIdentitydomainsNetworkPerimeter', 
               'Write-OCIIdentitydomainsNotificationSetting', 
               'Write-OCIIdentitydomainsPasswordPolicy', 
               'Write-OCIIdentitydomainsPolicy', 'Write-OCIIdentitydomainsRule', 
               'Write-OCIIdentitydomainsSchema', 
               'Write-OCIIdentitydomainsSecurityQuestionSetting', 
               'Write-OCIIdentitydomainsSelfRegistrationProfile', 
               'Write-OCIIdentitydomainsSetting', 
               'Write-OCIIdentitydomainsSocialIdentityProvider', 
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

