#
# Module manifest for module 'OCI.PSModules.Datasafe'
#
# Generated by: Oracle Cloud Infrastructure
#
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'assemblies/OCI.PSModules.Datasafe.dll'

# Version number of this module.
ModuleVersion = '66.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = 'acae3050-5046-4f4b-812f-d87bfcb51ba7'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'This modules provides Cmdlets for OCI Datasafe Service'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '66.0.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'assemblies/OCI.DotNetSDK.Datasafe.dll'

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
CmdletsToExport = 'Add-OCIDatasafeMaskingColumnsFromSdm', 
               'Edit-OCIDatasafeGlobalSettings', 'Enable-OCIDatasafeConfiguration', 
               'Enable-OCIDatasafeTargetDatabase', 'Get-OCIDatasafeAlert', 
               'Get-OCIDatasafeAlertAnalyticsList', 
               'Get-OCIDatasafeAlertPoliciesList', 'Get-OCIDatasafeAlertPolicy', 
               'Get-OCIDatasafeAlertPolicyRulesList', 'Get-OCIDatasafeAlertsList', 
               'Get-OCIDatasafeAuditArchiveRetrieval', 
               'Get-OCIDatasafeAuditArchiveRetrievalsList', 
               'Get-OCIDatasafeAuditEventAnalyticsList', 
               'Get-OCIDatasafeAuditEventsList', 
               'Get-OCIDatasafeAuditPoliciesList', 'Get-OCIDatasafeAuditPolicy', 
               'Get-OCIDatasafeAuditPolicyAnalyticsList', 
               'Get-OCIDatasafeAuditProfile', 
               'Get-OCIDatasafeAuditProfileAnalyticsList', 
               'Get-OCIDatasafeAuditProfilesList', 'Get-OCIDatasafeAuditTrail', 
               'Get-OCIDatasafeAuditTrailAnalyticsList', 
               'Get-OCIDatasafeAuditTrailsList', 
               'Get-OCIDatasafeAvailableAuditVolumesList', 
               'Get-OCIDatasafeCollectedAuditVolumesList', 
               'Get-OCIDatasafeColumnsList', 
               'Get-OCIDatasafeCompatibleFormatsForDataTypes', 
               'Get-OCIDatasafeCompatibleFormatsForSensitiveTypes', 
               'Get-OCIDatasafeConfiguration', 'Get-OCIDatasafeDifferenceColumn', 
               'Get-OCIDatasafeDifferenceColumnsList', 
               'Get-OCIDatasafeDiscoveryAnalyticsList', 
               'Get-OCIDatasafeDiscoveryJob', 'Get-OCIDatasafeDiscoveryJobResult', 
               'Get-OCIDatasafeDiscoveryJobResultsList', 
               'Get-OCIDatasafeDiscoveryJobsList', 'Get-OCIDatasafeFindingsList', 
               'Get-OCIDatasafeGrantsList', 'Get-OCIDatasafeLibraryMaskingFormat', 
               'Get-OCIDatasafeLibraryMaskingFormatsList', 
               'Get-OCIDatasafeMaskedColumnsList', 
               'Get-OCIDatasafeMaskingAnalyticsList', 
               'Get-OCIDatasafeMaskingColumn', 'Get-OCIDatasafeMaskingColumnsList', 
               'Get-OCIDatasafeMaskingObjectsList', 
               'Get-OCIDatasafeMaskingPoliciesList', 
               'Get-OCIDatasafeMaskingPolicy', 'Get-OCIDatasafeMaskingReport', 
               'Get-OCIDatasafeMaskingReportsList', 
               'Get-OCIDatasafeMaskingSchemasList', 
               'Get-OCIDatasafeOnPremConnector', 
               'Get-OCIDatasafeOnPremConnectorsList', 
               'Get-OCIDatasafePrivateEndpoint', 
               'Get-OCIDatasafePrivateEndpointsList', 'Get-OCIDatasafeProfile', 
               'Get-OCIDatasafeProfileAnalyticsList', 
               'Get-OCIDatasafeProfileSummariesList', 'Get-OCIDatasafeReport', 
               'Get-OCIDatasafeReportContent', 'Get-OCIDatasafeReportDefinition', 
               'Get-OCIDatasafeReportDefinitionsList', 
               'Get-OCIDatasafeReportsList', 'Get-OCIDatasafeRolesList', 
               'Get-OCIDatasafeSchemasList', 
               'Get-OCIDatasafeSdmMaskingPolicyDifference', 
               'Get-OCIDatasafeSdmMaskingPolicyDifferencesList', 
               'Get-OCIDatasafeSecurityAssessment', 
               'Get-OCIDatasafeSecurityAssessmentComparison', 
               'Get-OCIDatasafeSecurityAssessmentsList', 
               'Get-OCIDatasafeSensitiveColumn', 
               'Get-OCIDatasafeSensitiveColumnsList', 
               'Get-OCIDatasafeSensitiveDataModel', 
               'Get-OCIDatasafeSensitiveDataModelsList', 
               'Get-OCIDatasafeSensitiveObjectsList', 
               'Get-OCIDatasafeSensitiveSchemasList', 
               'Get-OCIDatasafeSensitiveType', 'Get-OCIDatasafeSensitiveTypesList', 
               'Get-OCIDatasafeTablesList', 
               'Get-OCIDatasafeTargetAlertPolicyAssociation', 
               'Get-OCIDatasafeTargetAlertPolicyAssociationsList', 
               'Get-OCIDatasafeTargetDatabase', 
               'Get-OCIDatasafeTargetDatabasesList', 
               'Get-OCIDatasafeUserAnalyticsList', 'Get-OCIDatasafeUserAssessment', 
               'Get-OCIDatasafeUserAssessmentComparison', 
               'Get-OCIDatasafeUserAssessmentsList', 'Get-OCIDatasafeUsersList', 
               'Get-OCIDatasafeWorkRequest', 
               'Get-OCIDatasafeWorkRequestErrorsList', 
               'Get-OCIDatasafeWorkRequestLogsList', 
               'Get-OCIDatasafeWorkRequestsList', 'Invoke-OCIDatasafeAlertsUpdate', 
               'Invoke-OCIDatasafeApplyDiscoveryJobResults', 
               'Invoke-OCIDatasafeApplySdmMaskingPolicyDifference', 
               'Invoke-OCIDatasafeCalculateAuditVolumeAvailable', 
               'Invoke-OCIDatasafeCalculateAuditVolumeCollected', 
               'Invoke-OCIDatasafeCompareSecurityAssessment', 
               'Invoke-OCIDatasafeCompareUserAssessment', 
               'Invoke-OCIDatasafeDeactivateTargetDatabase', 
               'Invoke-OCIDatasafeDiscoverAuditTrails', 
               'Invoke-OCIDatasafeDownloadDiscoveryReport', 
               'Invoke-OCIDatasafeDownloadMaskingLog', 
               'Invoke-OCIDatasafeDownloadMaskingPolicy', 
               'Invoke-OCIDatasafeDownloadMaskingReport', 
               'Invoke-OCIDatasafeDownloadPrivilegeScript', 
               'Invoke-OCIDatasafeDownloadSecurityAssessmentReport', 
               'Invoke-OCIDatasafeDownloadSensitiveDataModel', 
               'Invoke-OCIDatasafeDownloadUserAssessmentReport', 
               'Invoke-OCIDatasafeMaskData', 'Invoke-OCIDatasafePatchAlerts', 
               'Invoke-OCIDatasafePatchDiscoveryJobResults', 
               'Invoke-OCIDatasafePatchMaskingColumns', 
               'Invoke-OCIDatasafePatchSdmMaskingPolicyDifferenceColumns', 
               'Invoke-OCIDatasafePatchSensitiveColumns', 
               'Invoke-OCIDatasafePatchTargetAlertPolicyAssociation', 
               'Invoke-OCIDatasafeProvisionAuditPolicy', 
               'Invoke-OCIDatasafeRefreshSecurityAssessment', 
               'Invoke-OCIDatasafeRefreshUserAssessment', 
               'Invoke-OCIDatasafeResumeAuditTrail', 
               'Invoke-OCIDatasafeResumeWorkRequest', 
               'Invoke-OCIDatasafeRetrieveAuditPolicies', 
               'Invoke-OCIDatasafeScheduleReport', 
               'Invoke-OCIDatasafeSetSecurityAssessmentBaseline', 
               'Invoke-OCIDatasafeSetUserAssessmentBaseline', 
               'Invoke-OCIDatasafeSuspendWorkRequest', 
               'Invoke-OCIDatasafeUnsetSecurityAssessmentBaseline', 
               'Invoke-OCIDatasafeUnsetUserAssessmentBaseline', 
               'Move-OCIDatasafeAlertCompartment', 
               'Move-OCIDatasafeAuditArchiveRetrievalCompartment', 
               'Move-OCIDatasafeAuditPolicyCompartment', 
               'Move-OCIDatasafeAuditProfileCompartment', 
               'Move-OCIDatasafeDiscoveryJobCompartment', 
               'Move-OCIDatasafeLibraryMaskingFormatCompartment', 
               'Move-OCIDatasafeMaskingPolicyCompartment', 
               'Move-OCIDatasafeOnPremConnectorCompartment', 
               'Move-OCIDatasafePrivateEndpointCompartment', 
               'Move-OCIDatasafeReportCompartment', 
               'Move-OCIDatasafeReportDefinitionCompartment', 
               'Move-OCIDatasafeRetention', 
               'Move-OCIDatasafeSdmMaskingPolicyDifferenceCompartment', 
               'Move-OCIDatasafeSecurityAssessmentCompartment', 
               'Move-OCIDatasafeSensitiveDataModelCompartment', 
               'Move-OCIDatasafeSensitiveTypeCompartment', 
               'Move-OCIDatasafeTargetAlertPolicyAssociationCompartment', 
               'Move-OCIDatasafeTargetDatabaseCompartment', 
               'Move-OCIDatasafeUserAssessmentCompartment', 
               'New-OCIDatasafeAuditArchiveRetrieval', 
               'New-OCIDatasafeDiscoveryJob', 
               'New-OCIDatasafeDiscoveryReportForDownload', 
               'New-OCIDatasafeLibraryMaskingFormat', 
               'New-OCIDatasafeMaskingColumn', 'New-OCIDatasafeMaskingPolicy', 
               'New-OCIDatasafeMaskingPolicyForDownload', 
               'New-OCIDatasafeMaskingReportForDownload', 
               'New-OCIDatasafeOnPremConnector', 
               'New-OCIDatasafeOnPremConnectorConfiguration', 
               'New-OCIDatasafePrivateEndpoint', 'New-OCIDatasafeReport', 
               'New-OCIDatasafeReportDefinition', 
               'New-OCIDatasafeSdmMaskingPolicyDifference', 
               'New-OCIDatasafeSecurityAssessment', 
               'New-OCIDatasafeSecurityAssessmentReport', 
               'New-OCIDatasafeSensitiveColumn', 
               'New-OCIDatasafeSensitiveDataModel', 
               'New-OCIDatasafeSensitiveDataModelForDownload', 
               'New-OCIDatasafeSensitiveType', 
               'New-OCIDatasafeTargetAlertPolicyAssociation', 
               'New-OCIDatasafeTargetDatabase', 'New-OCIDatasafeUserAssessment', 
               'New-OCIDatasafeUserAssessmentReport', 
               'Remove-OCIDatasafeAuditArchiveRetrieval', 
               'Remove-OCIDatasafeAuditTrail', 'Remove-OCIDatasafeDiscoveryJob', 
               'Remove-OCIDatasafeDiscoveryJobResult', 
               'Remove-OCIDatasafeLibraryMaskingFormat', 
               'Remove-OCIDatasafeMaskingColumn', 
               'Remove-OCIDatasafeMaskingPolicy', 
               'Remove-OCIDatasafeOnPremConnector', 
               'Remove-OCIDatasafePrivateEndpoint', 
               'Remove-OCIDatasafeReportDefinition', 
               'Remove-OCIDatasafeScheduleReport', 
               'Remove-OCIDatasafeSdmMaskingPolicyDifference', 
               'Remove-OCIDatasafeSecurityAssessment', 
               'Remove-OCIDatasafeSensitiveColumn', 
               'Remove-OCIDatasafeSensitiveDataModel', 
               'Remove-OCIDatasafeSensitiveType', 
               'Remove-OCIDatasafeTargetAlertPolicyAssociation', 
               'Remove-OCIDatasafeTargetDatabase', 
               'Remove-OCIDatasafeUserAssessment', 'Start-OCIDatasafeAuditTrail', 
               'Stop-OCIDatasafeAuditTrail', 'Stop-OCIDatasafeWorkRequest', 
               'Update-OCIDatasafeAlert', 
               'Update-OCIDatasafeAuditArchiveRetrieval', 
               'Update-OCIDatasafeAuditPolicy', 'Update-OCIDatasafeAuditProfile', 
               'Update-OCIDatasafeAuditTrail', 
               'Update-OCIDatasafeLibraryMaskingFormat', 
               'Update-OCIDatasafeMaskingColumn', 
               'Update-OCIDatasafeMaskingPolicy', 
               'Update-OCIDatasafeOnPremConnector', 
               'Update-OCIDatasafeOnPremConnectorWallet', 
               'Update-OCIDatasafePrivateEndpoint', 
               'Update-OCIDatasafeReportDefinition', 
               'Update-OCIDatasafeSdmMaskingPolicyDifference', 
               'Update-OCIDatasafeSecurityAssessment', 
               'Update-OCIDatasafeSensitiveColumn', 
               'Update-OCIDatasafeSensitiveDataModel', 
               'Update-OCIDatasafeSensitiveType', 
               'Update-OCIDatasafeTargetAlertPolicyAssociation', 
               'Update-OCIDatasafeTargetDatabase', 
               'Update-OCIDatasafeUserAssessment', 
               'Write-OCIDatasafeMaskingPolicy', 
               'Write-OCIDatasafeSensitiveDataModel'

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
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure','Datasafe'

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

