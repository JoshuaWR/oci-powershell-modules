#
# Module manifest for module 'OCI.PSModules.Cloudguard'
#
# Generated by: Oracle Cloud Infrastructure
#
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'assemblies/OCI.PSModules.Cloudguard.dll'

# Version number of this module.
ModuleVersion = '52.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = '416303ec-c9d6-4a65-8413-14973e520be8'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'This modules provides Cmdlets for OCI Cloudguard Service'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '52.1.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'assemblies/OCI.DotNetSDK.Cloudguard.dll'

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
CmdletsToExport = 'Add-OCICloudguardCompartment', 
               'Get-OCICloudguardConditionMetadataType', 
               'Get-OCICloudguardConditionMetadataTypesList', 
               'Get-OCICloudguardConfiguration', 'Get-OCICloudguardDataMaskRule', 
               'Get-OCICloudguardDataMaskRulesList', 'Get-OCICloudguardDataSource', 
               'Get-OCICloudguardDataSourceEventsList', 
               'Get-OCICloudguardDataSourcesList', 'Get-OCICloudguardDetector', 
               'Get-OCICloudguardDetectorRecipe', 
               'Get-OCICloudguardDetectorRecipeDetectorRule', 
               'Get-OCICloudguardDetectorRecipeDetectorRulesList', 
               'Get-OCICloudguardDetectorRecipesList', 
               'Get-OCICloudguardDetectorRule', 
               'Get-OCICloudguardDetectorRulesList', 
               'Get-OCICloudguardDetectorsList', 
               'Get-OCICloudguardImpactedResourcesList', 
               'Get-OCICloudguardManagedList', 'Get-OCICloudguardManagedListsList', 
               'Get-OCICloudguardManagedListTypesList', 
               'Get-OCICloudguardPoliciesList', 'Get-OCICloudguardProblem', 
               'Get-OCICloudguardProblemEndpointsList', 
               'Get-OCICloudguardProblemEntitiesList', 
               'Get-OCICloudguardProblemHistoriesList', 
               'Get-OCICloudguardProblemsList', 
               'Get-OCICloudguardRecommendationsList', 
               'Get-OCICloudguardResourceProfile', 
               'Get-OCICloudguardResourceProfileEndpointsList', 
               'Get-OCICloudguardResourceProfileImpactedResourcesList', 
               'Get-OCICloudguardResourceProfilesList', 
               'Get-OCICloudguardResourceTypesList', 
               'Get-OCICloudguardResponderActivitiesList', 
               'Get-OCICloudguardResponderExecution', 
               'Get-OCICloudguardResponderExecutionsList', 
               'Get-OCICloudguardResponderRecipe', 
               'Get-OCICloudguardResponderRecipeResponderRule', 
               'Get-OCICloudguardResponderRecipeResponderRulesList', 
               'Get-OCICloudguardResponderRecipesList', 
               'Get-OCICloudguardResponderRule', 
               'Get-OCICloudguardResponderRulesList', 
               'Get-OCICloudguardSecurityPoliciesList', 
               'Get-OCICloudguardSecurityPolicy', 
               'Get-OCICloudguardSecurityRecipe', 
               'Get-OCICloudguardSecurityRecipesList', 
               'Get-OCICloudguardSecurityZone', 
               'Get-OCICloudguardSecurityZonesList', 'Get-OCICloudguardSighting', 
               'Get-OCICloudguardSightingEndpointsList', 
               'Get-OCICloudguardSightingImpactedResourcesList', 
               'Get-OCICloudguardSightingsList', 'Get-OCICloudguardTacticsList', 
               'Get-OCICloudguardTarget', 'Get-OCICloudguardTargetDetectorRecipe', 
               'Get-OCICloudguardTargetDetectorRecipeDetectorRule', 
               'Get-OCICloudguardTargetDetectorRecipeDetectorRulesList', 
               'Get-OCICloudguardTargetDetectorRecipesList', 
               'Get-OCICloudguardTargetResponderRecipe', 
               'Get-OCICloudguardTargetResponderRecipeResponderRule', 
               'Get-OCICloudguardTargetResponderRecipeResponderRulesList', 
               'Get-OCICloudguardTargetResponderRecipesList', 
               'Get-OCICloudguardTargetsList', 'Get-OCICloudguardTechniquesList', 
               'Get-OCICloudguardWorkRequest', 
               'Get-OCICloudguardWorkRequestErrorsList', 
               'Get-OCICloudguardWorkRequestLogsList', 
               'Get-OCICloudguardWorkRequestsList', 
               'Invoke-OCICloudguardExecuteResponderExecution', 
               'Invoke-OCICloudguardRequestRiskScores', 
               'Invoke-OCICloudguardRequestSecurityScores', 
               'Invoke-OCICloudguardRequestSecurityScoreSummarizedTrend', 
               'Invoke-OCICloudguardRequestSummarizedActivityProblems', 
               'Invoke-OCICloudguardRequestSummarizedProblems', 
               'Invoke-OCICloudguardRequestSummarizedResponderExecutions', 
               'Invoke-OCICloudguardRequestSummarizedRiskScores', 
               'Invoke-OCICloudguardRequestSummarizedSecurityScores', 
               'Invoke-OCICloudguardRequestSummarizedTopTrendResourceProfileRiskScores', 
               'Invoke-OCICloudguardRequestSummarizedTrendProblems', 
               'Invoke-OCICloudguardRequestSummarizedTrendResourceRiskScores', 
               'Invoke-OCICloudguardRequestSummarizedTrendResponderExecutions', 
               'Invoke-OCICloudguardRequestSummarizedTrendSecurityScores', 
               'Invoke-OCICloudguardSkipBulkResponderExecution', 
               'Invoke-OCICloudguardSkipResponderExecution', 
               'Invoke-OCICloudguardTriggerResponder', 
               'Move-OCICloudguardDataSourceCompartment', 
               'Move-OCICloudguardDetectorRecipeCompartment', 
               'Move-OCICloudguardManagedListCompartment', 
               'Move-OCICloudguardResponderRecipeCompartment', 
               'Move-OCICloudguardSecurityRecipeCompartment', 
               'Move-OCICloudguardSecurityZoneCompartment', 
               'New-OCICloudguardDataMaskRule', 'New-OCICloudguardDataSource', 
               'New-OCICloudguardDetectorRecipe', 
               'New-OCICloudguardDetectorRecipeDetectorRule', 
               'New-OCICloudguardManagedList', 'New-OCICloudguardResponderRecipe', 
               'New-OCICloudguardSecurityRecipe', 'New-OCICloudguardSecurityZone', 
               'New-OCICloudguardTarget', 'New-OCICloudguardTargetDetectorRecipe', 
               'New-OCICloudguardTargetResponderRecipe', 
               'Remove-OCICloudguardCompartment', 
               'Remove-OCICloudguardDataMaskRule', 
               'Remove-OCICloudguardDataSource', 
               'Remove-OCICloudguardDetectorRecipe', 
               'Remove-OCICloudguardDetectorRecipeDetectorRule', 
               'Remove-OCICloudguardDetectorRecipeDetectorRuleDataSource', 
               'Remove-OCICloudguardManagedList', 
               'Remove-OCICloudguardResponderRecipe', 
               'Remove-OCICloudguardSecurityRecipe', 
               'Remove-OCICloudguardSecurityZone', 'Remove-OCICloudguardTarget', 
               'Remove-OCICloudguardTargetDetectorRecipe', 
               'Remove-OCICloudguardTargetResponderRecipe', 
               'Stop-OCICloudguardWorkRequest', 
               'Update-OCICloudguardBulkProblemStatus', 
               'Update-OCICloudguardConfiguration', 
               'Update-OCICloudguardDataMaskRule', 
               'Update-OCICloudguardDataSource', 
               'Update-OCICloudguardDetectorRecipe', 
               'Update-OCICloudguardDetectorRecipeDetectorRule', 
               'Update-OCICloudguardManagedList', 
               'Update-OCICloudguardProblemStatus', 
               'Update-OCICloudguardResponderRecipe', 
               'Update-OCICloudguardResponderRecipeResponderRule', 
               'Update-OCICloudguardSecurityRecipe', 
               'Update-OCICloudguardSecurityZone', 'Update-OCICloudguardTarget', 
               'Update-OCICloudguardTargetDetectorRecipe', 
               'Update-OCICloudguardTargetDetectorRecipeDetectorRule', 
               'Update-OCICloudguardTargetResponderRecipe', 
               'Update-OCICloudguardTargetResponderRecipeResponderRule'

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
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure','Cloudguard'

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/oracle/oci-powershell-modules/blob/master/LICENSE.txt'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/oracle/oci-powershell-modules/'

        # A URL to an icon representing this module.
        IconUri = 'https://github.com/oracle/oci-powershell-modules/blob/master/icon.png'

        # ReleaseNotes of this module
        ReleaseNotes = 'https://github.com/oracle/oci-powershell-modules/blob/master/CHANGELOG.rst'

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

