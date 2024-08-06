#
# Module manifest for module 'OCI.PSModules.Database'
#
# Generated by: Oracle Cloud Infrastructure
#
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'assemblies/OCI.PSModules.Database.dll'

# Version number of this module.
ModuleVersion = '88.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = 'e1b520e7-13c2-41a0-be48-3eacc401dff5'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'This modules provides Cmdlets for OCI Database Service'

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
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '88.0.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'assemblies/OCI.DotNetSDK.Database.dll'

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
CmdletsToExport = 'Add-OCIDatabaseStorageCapacityCloudExadataInfrastructure', 
               'Add-OCIDatabaseStorageCapacityExadataInfrastructure', 
               'Add-OCIDatabaseVirtualMachineToCloudVmCluster', 
               'Add-OCIDatabaseVirtualMachineToVmCluster', 
               'Complete-OCIDatabaseExternalBackupJob', 
               'Confirm-OCIDatabaseVmClusterNetwork', 
               'Disable-OCIDatabaseAutonomousDatabaseManagement', 
               'Disable-OCIDatabaseAutonomousDatabaseOperationsInsights', 
               'Disable-OCIDatabaseExternalContainerDatabaseDatabaseManagement', 
               'Disable-OCIDatabaseExternalContainerDatabaseStackMonitoring', 
               'Disable-OCIDatabaseExternalNonContainerDatabaseDatabaseManagement', 
               'Disable-OCIDatabaseExternalNonContainerDatabaseOperationsInsights', 
               'Disable-OCIDatabaseExternalNonContainerDatabaseStackMonitoring', 
               'Disable-OCIDatabaseExternalPluggableDatabaseDatabaseManagement', 
               'Disable-OCIDatabaseExternalPluggableDatabaseOperationsInsights', 
               'Disable-OCIDatabaseExternalPluggableDatabaseStackMonitoring', 
               'Disable-OCIDatabaseManagement', 
               'Disable-OCIDatabasePluggableDatabaseManagement', 
               'Edit-OCIDatabaseManagement', 
               'Edit-OCIDatabasePluggableDatabaseManagement', 
               'Enable-OCIDatabaseAutonomousDatabaseManagement', 
               'Enable-OCIDatabaseAutonomousDatabaseOperationsInsights', 
               'Enable-OCIDatabaseExadataInfrastructure', 
               'Enable-OCIDatabaseExternalContainerDatabaseDatabaseManagement', 
               'Enable-OCIDatabaseExternalContainerDatabaseStackMonitoring', 
               'Enable-OCIDatabaseExternalNonContainerDatabaseDatabaseManagement', 
               'Enable-OCIDatabaseExternalNonContainerDatabaseOperationsInsights', 
               'Enable-OCIDatabaseExternalNonContainerDatabaseStackMonitoring', 
               'Enable-OCIDatabaseExternalPluggableDatabaseDatabaseManagement', 
               'Enable-OCIDatabaseExternalPluggableDatabaseOperationsInsights', 
               'Enable-OCIDatabaseExternalPluggableDatabaseStackMonitoring', 
               'Enable-OCIDatabaseManagement', 
               'Enable-OCIDatabasePluggableDatabaseManagement', 'Get-OCIDatabase', 
               'Get-OCIDatabaseApplicationVip', 
               'Get-OCIDatabaseApplicationVipsList', 
               'Get-OCIDatabaseAutonomousContainerDatabase', 
               'Get-OCIDatabaseAutonomousContainerDatabaseDataguardAssociation', 
               'Get-OCIDatabaseAutonomousContainerDatabaseDataguardAssociationsList', 
               'Get-OCIDatabaseAutonomousContainerDatabaseResourceUsage', 
               'Get-OCIDatabaseAutonomousContainerDatabasesList', 
               'Get-OCIDatabaseAutonomousContainerDatabaseVersionsList', 
               'Get-OCIDatabaseAutonomousDatabase', 
               'Get-OCIDatabaseAutonomousDatabaseBackup', 
               'Get-OCIDatabaseAutonomousDatabaseBackupsList', 
               'Get-OCIDatabaseAutonomousDatabaseCharacterSetsList', 
               'Get-OCIDatabaseAutonomousDatabaseClonesList', 
               'Get-OCIDatabaseAutonomousDatabaseDataguardAssociation', 
               'Get-OCIDatabaseAutonomousDatabaseDataguardAssociationsList', 
               'Get-OCIDatabaseAutonomousDatabasePeersList', 
               'Get-OCIDatabaseAutonomousDatabaseRefreshableClonesList', 
               'Get-OCIDatabaseAutonomousDatabaseRegionalWallet', 
               'Get-OCIDatabaseAutonomousDatabasesList', 
               'Get-OCIDatabaseAutonomousDatabaseSoftwareImage', 
               'Get-OCIDatabaseAutonomousDatabaseSoftwareImagesList', 
               'Get-OCIDatabaseAutonomousDatabaseWallet', 
               'Get-OCIDatabaseAutonomousDbPreviewVersionsList', 
               'Get-OCIDatabaseAutonomousDbVersionsList', 
               'Get-OCIDatabaseAutonomousExadataInfrastructure', 
               'Get-OCIDatabaseAutonomousExadataInfrastructureShapesList', 
               'Get-OCIDatabaseAutonomousExadataInfrastructuresList', 
               'Get-OCIDatabaseAutonomousPatch', 
               'Get-OCIDatabaseAutonomousVirtualMachine', 
               'Get-OCIDatabaseAutonomousVirtualMachinesList', 
               'Get-OCIDatabaseAutonomousVmCluster', 
               'Get-OCIDatabaseAutonomousVmClusterAcdResourceUsageList', 
               'Get-OCIDatabaseAutonomousVmClusterResourceUsage', 
               'Get-OCIDatabaseAutonomousVmClustersList', 'Get-OCIDatabaseBackup', 
               'Get-OCIDatabaseBackupDestination', 
               'Get-OCIDatabaseBackupDestinationList', 
               'Get-OCIDatabaseBackupsList', 
               'Get-OCIDatabaseCloudAutonomousVmCluster', 
               'Get-OCIDatabaseCloudAutonomousVmClusterAcdResourceUsageList', 
               'Get-OCIDatabaseCloudAutonomousVmClusterResourceUsage', 
               'Get-OCIDatabaseCloudAutonomousVmClustersList', 
               'Get-OCIDatabaseCloudExadataInfrastructure', 
               'Get-OCIDatabaseCloudExadataInfrastructuresList', 
               'Get-OCIDatabaseCloudExadataInfrastructureUnallocatedResources', 
               'Get-OCIDatabaseCloudVmCluster', 
               'Get-OCIDatabaseCloudVmClusterIormConfig', 
               'Get-OCIDatabaseCloudVmClustersList', 
               'Get-OCIDatabaseCloudVmClusterUpdate', 
               'Get-OCIDatabaseCloudVmClusterUpdateHistoryEntriesList', 
               'Get-OCIDatabaseCloudVmClusterUpdateHistoryEntry', 
               'Get-OCIDatabaseCloudVmClusterUpdatesList', 
               'Get-OCIDatabaseConsoleConnection', 
               'Get-OCIDatabaseConsoleConnectionsList', 
               'Get-OCIDatabaseConsoleHistoriesList', 
               'Get-OCIDatabaseConsoleHistory', 
               'Get-OCIDatabaseConsoleHistoryContent', 
               'Get-OCIDatabaseContainerDatabasePatchesList', 
               'Get-OCIDatabaseDataGuardAssociation', 
               'Get-OCIDatabaseDataGuardAssociationsList', 'Get-OCIDatabaseDbHome', 
               'Get-OCIDatabaseDbHomePatch', 'Get-OCIDatabaseDbHomePatchesList', 
               'Get-OCIDatabaseDbHomePatchHistoryEntriesList', 
               'Get-OCIDatabaseDbHomePatchHistoryEntry', 
               'Get-OCIDatabaseDbHomesList', 'Get-OCIDatabaseDbNode', 
               'Get-OCIDatabaseDbNodesList', 'Get-OCIDatabaseDbServer', 
               'Get-OCIDatabaseDbServersList', 'Get-OCIDatabaseDbSystem', 
               'Get-OCIDatabaseDbSystemComputePerformancesList', 
               'Get-OCIDatabaseDbSystemPatch', 
               'Get-OCIDatabaseDbSystemPatchesList', 
               'Get-OCIDatabaseDbSystemPatchHistoryEntriesList', 
               'Get-OCIDatabaseDbSystemPatchHistoryEntry', 
               'Get-OCIDatabaseDbSystemShapesList', 'Get-OCIDatabaseDbSystemsList', 
               'Get-OCIDatabaseDbSystemStoragePerformancesList', 
               'Get-OCIDatabaseDbSystemUpgradeHistoryEntriesList', 
               'Get-OCIDatabaseDbSystemUpgradeHistoryEntry', 
               'Get-OCIDatabaseDbVersionsList', 
               'Get-OCIDatabaseExadataInfrastructure', 
               'Get-OCIDatabaseExadataInfrastructureOcpus', 
               'Get-OCIDatabaseExadataInfrastructuresList', 
               'Get-OCIDatabaseExadataInfrastructureUnAllocatedResources', 
               'Get-OCIDatabaseExadataIormConfig', 'Get-OCIDatabaseExadbVmCluster', 
               'Get-OCIDatabaseExadbVmClustersList', 
               'Get-OCIDatabaseExadbVmClusterUpdate', 
               'Get-OCIDatabaseExadbVmClusterUpdateHistoryEntriesList', 
               'Get-OCIDatabaseExadbVmClusterUpdateHistoryEntry', 
               'Get-OCIDatabaseExadbVmClusterUpdatesList', 
               'Get-OCIDatabaseExascaleDbStorageVault', 
               'Get-OCIDatabaseExascaleDbStorageVaultsList', 
               'Get-OCIDatabaseExternalBackupJob', 
               'Get-OCIDatabaseExternalContainerDatabase', 
               'Get-OCIDatabaseExternalContainerDatabasesList', 
               'Get-OCIDatabaseExternalDatabaseConnector', 
               'Get-OCIDatabaseExternalDatabaseConnectorsList', 
               'Get-OCIDatabaseExternalNonContainerDatabase', 
               'Get-OCIDatabaseExternalNonContainerDatabasesList', 
               'Get-OCIDatabaseExternalPluggableDatabase', 
               'Get-OCIDatabaseExternalPluggableDatabasesList', 
               'Get-OCIDatabaseFlexComponentsList', 
               'Get-OCIDatabaseGiVersionMinorVersionsList', 
               'Get-OCIDatabaseGiVersionsList', 
               'Get-OCIDatabaseInfrastructureTargetVersions', 
               'Get-OCIDatabaseKeyStore', 'Get-OCIDatabaseKeyStoresList', 
               'Get-OCIDatabaseMaintenanceRun', 
               'Get-OCIDatabaseMaintenanceRunHistory', 
               'Get-OCIDatabaseMaintenanceRunHistoryList', 
               'Get-OCIDatabaseMaintenanceRunsList', 'Get-OCIDatabaseOneoffPatch', 
               'Get-OCIDatabaseOneoffPatchesList', 
               'Get-OCIDatabasePdbConversionHistoryEntriesList', 
               'Get-OCIDatabasePdbConversionHistoryEntry', 
               'Get-OCIDatabasePluggableDatabase', 
               'Get-OCIDatabasePluggableDatabasesList', 'Get-OCIDatabasesList', 
               'Get-OCIDatabaseSoftwareImage', 'Get-OCIDatabaseSoftwareImagesList', 
               'Get-OCIDatabaseSystemVersionsList', 
               'Get-OCIDatabaseUpgradeHistoryEntriesList', 
               'Get-OCIDatabaseUpgradeHistoryEntry', 'Get-OCIDatabaseVmCluster', 
               'Get-OCIDatabaseVmClusterNetwork', 
               'Get-OCIDatabaseVmClusterNetworksList', 
               'Get-OCIDatabaseVmClusterPatch', 
               'Get-OCIDatabaseVmClusterPatchesList', 
               'Get-OCIDatabaseVmClusterPatchHistoryEntriesList', 
               'Get-OCIDatabaseVmClusterPatchHistoryEntry', 
               'Get-OCIDatabaseVmClustersList', 'Get-OCIDatabaseVmClusterUpdate', 
               'Get-OCIDatabaseVmClusterUpdateHistoryEntriesList', 
               'Get-OCIDatabaseVmClusterUpdateHistoryEntry', 
               'Get-OCIDatabaseVmClusterUpdatesList', 
               'Invoke-OCIDatabaseAutonomousDatabaseManualRefresh', 
               'Invoke-OCIDatabaseCheckExternalDatabaseConnectorConnectionStatus', 
               'Invoke-OCIDatabaseConfigureAutonomousDatabaseVaultKey', 
               'Invoke-OCIDatabaseConfigureSaasAdminUser', 
               'Invoke-OCIDatabaseConfirmKeyStoreDetailsAreCorrect', 
               'Invoke-OCIDatabaseConvertToPdb', 
               'Invoke-OCIDatabaseConvertToRegularPluggableDatabase', 
               'Invoke-OCIDatabaseDbNodeAction', 
               'Invoke-OCIDatabaseDownloadExadataInfrastructureConfigFile', 
               'Invoke-OCIDatabaseDownloadOneoffPatch', 
               'Invoke-OCIDatabaseDownloadValidationReport', 
               'Invoke-OCIDatabaseDownloadVmClusterNetworkConfigFile', 
               'Invoke-OCIDatabaseFailoverAutonomousContainerDatabaseDataguardAssociation', 
               'Invoke-OCIDatabaseFailOverAutonomousDatabase', 
               'Invoke-OCIDatabaseFailoverDataGuardAssociation', 
               'Invoke-OCIDatabaseLaunchAutonomousExadataInfrastructure', 
               'Invoke-OCIDatabaseLocalClonePluggableDatabase', 
               'Invoke-OCIDatabaseMigrateExadataDbSystemResourceModel', 
               'Invoke-OCIDatabaseMigrateVaultKey', 
               'Invoke-OCIDatabaseRefreshPluggableDatabase', 
               'Invoke-OCIDatabaseReinstateAutonomousContainerDatabaseDataguardAssociation', 
               'Invoke-OCIDatabaseReinstateDataGuardAssociation', 
               'Invoke-OCIDatabaseRemoteClonePluggableDatabase', 
               'Invoke-OCIDatabaseResizeVmClusterNetwork', 
               'Invoke-OCIDatabaseResourcePoolShapes', 
               'Invoke-OCIDatabaseRotateAutonomousContainerDatabaseEncryptionKey', 
               'Invoke-OCIDatabaseRotateAutonomousDatabaseEncryptionKey', 
               'Invoke-OCIDatabaseRotateAutonomousVmClusterOrdsCerts', 
               'Invoke-OCIDatabaseRotateAutonomousVmClusterSslCerts', 
               'Invoke-OCIDatabaseRotateCloudAutonomousVmClusterOrdsCerts', 
               'Invoke-OCIDatabaseRotateCloudAutonomousVmClusterSslCerts', 
               'Invoke-OCIDatabaseRotateOrdsCerts', 
               'Invoke-OCIDatabaseRotatePluggableDatabaseEncryptionKey', 
               'Invoke-OCIDatabaseRotateSslCerts', 
               'Invoke-OCIDatabaseRotateVaultKey', 
               'Invoke-OCIDatabaseSaasAdminUserStatus', 
               'Invoke-OCIDatabaseScanExternalContainerDatabasePluggableDatabases', 
               'Invoke-OCIDatabaseShrinkAutonomousDatabase', 
               'Invoke-OCIDatabaseSwitchoverAutonomousContainerDatabaseDataguardAssociation', 
               'Invoke-OCIDatabaseSwitchoverAutonomousDatabase', 
               'Invoke-OCIDatabaseSwitchoverDataGuardAssociation', 
               'Invoke-OCIDatabaseTerminateAutonomousContainerDatabase', 
               'Invoke-OCIDatabaseTerminateAutonomousExadataInfrastructure', 
               'Invoke-OCIDatabaseTerminateDbSystem', 
               'Invoke-OCIDatabaseUpgradeDatabase', 
               'Invoke-OCIDatabaseUpgradeDbSystem', 
               'Move-OCIDatabaseAutonomousContainerDatabaseCompartment', 
               'Move-OCIDatabaseAutonomousDatabaseCompartment', 
               'Move-OCIDatabaseAutonomousDatabaseSoftwareImageCompartment', 
               'Move-OCIDatabaseAutonomousDatabaseSubscription', 
               'Move-OCIDatabaseAutonomousExadataInfrastructureCompartment', 
               'Move-OCIDatabaseAutonomousVmClusterCompartment', 
               'Move-OCIDatabaseBackupDestinationCompartment', 
               'Move-OCIDatabaseCloudAutonomousVmClusterCompartment', 
               'Move-OCIDatabaseCloudExadataInfrastructureCompartment', 
               'Move-OCIDatabaseCloudExadataInfrastructureSubscription', 
               'Move-OCIDatabaseCloudVmClusterCompartment', 
               'Move-OCIDatabaseCloudVmClusterSubscription', 
               'Move-OCIDatabaseDataguardRole', 
               'Move-OCIDatabaseDbSystemCompartment', 
               'Move-OCIDatabaseDisasterRecoveryConfiguration', 
               'Move-OCIDatabaseExadataInfrastructureCompartment', 
               'Move-OCIDatabaseExadbVmClusterCompartment', 
               'Move-OCIDatabaseExascaleDbStorageVaultCompartment', 
               'Move-OCIDatabaseExternalContainerDatabaseCompartment', 
               'Move-OCIDatabaseExternalNonContainerDatabaseCompartment', 
               'Move-OCIDatabaseExternalPluggableDatabaseCompartment', 
               'Move-OCIDatabaseKeyStoreCompartment', 
               'Move-OCIDatabaseKeyStoreType', 
               'Move-OCIDatabaseOneoffPatchCompartment', 
               'Move-OCIDatabaseSoftwareImageCompartment', 
               'Move-OCIDatabaseVmClusterCompartment', 'New-OCIDatabase', 
               'New-OCIDatabaseApplicationVip', 
               'New-OCIDatabaseAutonomousContainerDatabase', 
               'New-OCIDatabaseAutonomousContainerDatabaseDataguardAssociation', 
               'New-OCIDatabaseAutonomousDatabase', 
               'New-OCIDatabaseAutonomousDatabaseBackup', 
               'New-OCIDatabaseAutonomousDatabaseSoftwareImage', 
               'New-OCIDatabaseAutonomousDatabaseWallet', 
               'New-OCIDatabaseAutonomousVmCluster', 'New-OCIDatabaseBackup', 
               'New-OCIDatabaseBackupDestination', 
               'New-OCIDatabaseCloudAutonomousVmCluster', 
               'New-OCIDatabaseCloudExadataInfrastructure', 
               'New-OCIDatabaseCloudVmCluster', 'New-OCIDatabaseConsoleConnection', 
               'New-OCIDatabaseConsoleHistory', 
               'New-OCIDatabaseDataGuardAssociation', 'New-OCIDatabaseDbHome', 
               'New-OCIDatabaseDbSystem', 'New-OCIDatabaseExadataInfrastructure', 
               'New-OCIDatabaseExadbVmCluster', 
               'New-OCIDatabaseExascaleDbStorageVault', 
               'New-OCIDatabaseExternalBackupJob', 
               'New-OCIDatabaseExternalContainerDatabase', 
               'New-OCIDatabaseExternalDatabaseConnector', 
               'New-OCIDatabaseExternalNonContainerDatabase', 
               'New-OCIDatabaseExternalPluggableDatabase', 
               'New-OCIDatabaseKeyStore', 'New-OCIDatabaseMaintenanceRun', 
               'New-OCIDatabaseOneoffPatch', 'New-OCIDatabasePluggableDatabase', 
               'New-OCIDatabaseRecommendedVmClusterNetwork', 
               'New-OCIDatabaseSoftwareImage', 'New-OCIDatabaseVmCluster', 
               'New-OCIDatabaseVmClusterNetwork', 
               'Register-OCIDatabaseAutonomousDatabaseDataSafe', 
               'Remove-OCIDatabase', 'Remove-OCIDatabaseApplicationVip', 
               'Remove-OCIDatabaseAutonomousDatabase', 
               'Remove-OCIDatabaseAutonomousDatabaseBackup', 
               'Remove-OCIDatabaseAutonomousDatabaseSoftwareImage', 
               'Remove-OCIDatabaseAutonomousVmCluster', 'Remove-OCIDatabaseBackup', 
               'Remove-OCIDatabaseBackupDestination', 
               'Remove-OCIDatabaseCloudAutonomousVmCluster', 
               'Remove-OCIDatabaseCloudExadataInfrastructure', 
               'Remove-OCIDatabaseCloudVmCluster', 
               'Remove-OCIDatabaseConsoleConnection', 
               'Remove-OCIDatabaseConsoleHistory', 'Remove-OCIDatabaseDbHome', 
               'Remove-OCIDatabaseExadataInfrastructure', 
               'Remove-OCIDatabaseExadbVmCluster', 
               'Remove-OCIDatabaseExascaleDbStorageVault', 
               'Remove-OCIDatabaseExternalContainerDatabase', 
               'Remove-OCIDatabaseExternalDatabaseConnector', 
               'Remove-OCIDatabaseExternalNonContainerDatabase', 
               'Remove-OCIDatabaseExternalPluggableDatabase', 
               'Remove-OCIDatabaseKeyStore', 'Remove-OCIDatabaseOneoffPatch', 
               'Remove-OCIDatabasePluggableDatabase', 
               'Remove-OCIDatabaseSoftwareImage', 
               'Remove-OCIDatabaseVirtualMachineFromCloudVmCluster', 
               'Remove-OCIDatabaseVirtualMachineFromExadbVmCluster', 
               'Remove-OCIDatabaseVirtualMachineFromVmCluster', 
               'Remove-OCIDatabaseVmCluster', 'Remove-OCIDatabaseVmClusterNetwork', 
               'Restart-OCIDatabaseAutonomousContainerDatabase', 
               'Restart-OCIDatabaseAutonomousDatabase', 'Restore-OCIDatabase', 
               'Restore-OCIDatabaseAutonomousDatabase', 
               'Start-OCIDatabaseAutonomousDatabase', 
               'Start-OCIDatabasePluggableDatabase', 
               'Stop-OCIDatabaseAutonomousDatabase', 'Stop-OCIDatabaseBackup', 
               'Stop-OCIDatabasePluggableDatabase', 
               'Unregister-OCIDatabaseAutonomousDatabaseDataSafe', 
               'Update-OCIDatabase', 
               'Update-OCIDatabaseAutonomousContainerDatabase', 
               'Update-OCIDatabaseAutonomousContainerDatabaseDataguardAssociation', 
               'Update-OCIDatabaseAutonomousDatabase', 
               'Update-OCIDatabaseAutonomousDatabaseBackup', 
               'Update-OCIDatabaseAutonomousDatabaseRegionalWallet', 
               'Update-OCIDatabaseAutonomousDatabaseSoftwareImage', 
               'Update-OCIDatabaseAutonomousDatabaseWallet', 
               'Update-OCIDatabaseAutonomousExadataInfrastructure', 
               'Update-OCIDatabaseAutonomousVmCluster', 
               'Update-OCIDatabaseBackupDestination', 
               'Update-OCIDatabaseCloudAutonomousVmCluster', 
               'Update-OCIDatabaseCloudExadataInfrastructure', 
               'Update-OCIDatabaseCloudVmCluster', 
               'Update-OCIDatabaseCloudVmClusterIormConfig', 
               'Update-OCIDatabaseConsoleConnection', 
               'Update-OCIDatabaseConsoleHistory', 
               'Update-OCIDatabaseDataGuardAssociation', 
               'Update-OCIDatabaseDbHome', 'Update-OCIDatabaseDbNode', 
               'Update-OCIDatabaseDbSystem', 
               'Update-OCIDatabaseExadataInfrastructure', 
               'Update-OCIDatabaseExadataIormConfig', 
               'Update-OCIDatabaseExadbVmCluster', 
               'Update-OCIDatabaseExascaleDbStorageVault', 
               'Update-OCIDatabaseExternalContainerDatabase', 
               'Update-OCIDatabaseExternalDatabaseConnector', 
               'Update-OCIDatabaseExternalNonContainerDatabase', 
               'Update-OCIDatabaseExternalPluggableDatabase', 
               'Update-OCIDatabaseKeyStore', 'Update-OCIDatabaseMaintenanceRun', 
               'Update-OCIDatabaseOneoffPatch', 
               'Update-OCIDatabasePluggableDatabase', 
               'Update-OCIDatabaseSoftwareImage', 'Update-OCIDatabaseVmCluster', 
               'Update-OCIDatabaseVmClusterNetwork'

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
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure','Database'

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

