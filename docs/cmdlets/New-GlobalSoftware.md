---
title: New-GlobalSoftware
---

# New-GlobalSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGlobalSoftware` |
| Source | `Cmdlets/NewGlobalSoftware.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AgentIntegrationTypeId | `Nullable`1` | False | — | All | None |
| ChocoProviderSoftwareId | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| CustomAuditProperties | `ICollection`1` | False | — | All | None |
| DetectionMethod | `DetectionMethod` | True | — | All | None |
| DetectionScript | `Script` | True | — | All | None |
| DetectionScriptId | `Nullable`1` | False | — | All | None |
| DetectionScriptType | `DatabaseType` | True | — | All | None |
| DownloadInstallerScript | `Script` | True | — | All | None |
| DownloadInstallerScriptId | `Nullable`1` | False | — | All | None |
| DownloadInstallerScriptType | `DatabaseType` | True | — | All | None |
| DynamicVersionsScript | `Script` | True | — | All | None |
| DynamicVersionsScriptId | `Nullable`1` | False | — | All | None |
| DynamicVersionsScriptType | `DatabaseType` | True | — | All | None |
| Hidden | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Identifier | `String` | False | — | All | None |
| InstallOrder | `Int32` | True | — | All | None |
| InstallScript | `Script` | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| InstallScriptType | `DatabaseType` | True | — | All | None |
| LicenseDescription | `String` | False | — | All | None |
| LicenseRequirement | `SoftwareLicenseRequirement` | True | — | All | None |
| LicenseType | `LicenseType` | True | — | All | None |
| MaintenanceSpecifier | `MaintenanceSpecifier` | True | — | All | None |
| MaintenanceTask | `MaintenanceTask` | True | — | All | None |
| MaintenanceTaskId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskType | `DatabaseType` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| Name | `String` | False | — | All | None |
| NiniteProviderSoftwareId | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| PostInstallScript | `Script` | True | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostInstallScriptType | `DatabaseType` | True | — | All | None |
| PostUninstallScript | `Script` | True | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptType | `DatabaseType` | True | — | All | None |
| RebootNeeded | `Boolean` | True | — | All | None |
| Recommended | `Boolean` | True | — | All | None |
| RelativeCacheSourcePath | `Guid` | True | — | All | None |
| RepairScript | `Script` | True | — | All | None |
| RepairScriptId | `Nullable`1` | False | — | All | None |
| RepairScriptType | `DatabaseType` | True | — | All | None |
| RepairType | `RepairActionType` | True | — | All | None |
| SoftwareIcon | `Media` | True | — | All | None |
| SoftwareIconMediaId | `Nullable`1` | False | — | All | None |
| SoftwarePrerequisites | `ICollection`1` | False | — | All | None |
| SoftwareTableName | `String` | False | — | All | None |
| SoftwareTableNameSearchMode | `SoftwareTableNameSearchMode` | True | — | All | None |
| SoftwareType | `SoftwareType` | True | — | All | None |
| SoftwareVersions | `ICollection`1` | False | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScript | `Script` | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | `DatabaseType` | True | — | All | None |
| UninstallScript | `Script` | True | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptType | `DatabaseType` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UpgradeCode | `String` | False | — | All | None |
| UpgradeScript | `Script` | True | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeScriptType | `DatabaseType` | True | — | All | None |
| UpgradeStrategy | `UpdateActionType` | True | — | All | None |
| UseDynamicVersions | `Boolean` | True | — | All | None |
| UseSoftwareTableDetection | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
