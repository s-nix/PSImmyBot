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
| DetectionMethod | [DetectionMethod](../models/DetectionMethod.md) | True | — | All | None |
| DetectionScript | [Script](../models/Script.md) | True | — | All | None |
| DetectionScriptId | `Nullable`1` | False | — | All | None |
| DetectionScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DownloadInstallerScript | [Script](../models/Script.md) | True | — | All | None |
| DownloadInstallerScriptId | `Nullable`1` | False | — | All | None |
| DownloadInstallerScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DynamicVersionsScript | [Script](../models/Script.md) | True | — | All | None |
| DynamicVersionsScriptId | `Nullable`1` | False | — | All | None |
| DynamicVersionsScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| Hidden | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Identifier | `String` | False | — | All | None |
| InstallOrder | `Int32` | True | — | All | None |
| InstallScript | [Script](../models/Script.md) | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| InstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| LicenseDescription | `String` | False | — | All | None |
| LicenseRequirement | [SoftwareLicenseRequirement](../models/SoftwareLicenseRequirement.md) | True | — | All | None |
| LicenseType | [LicenseType](../models/LicenseType.md) | True | — | All | None |
| MaintenanceSpecifier | [MaintenanceSpecifier](../models/MaintenanceSpecifier.md) | True | — | All | None |
| MaintenanceTask | [MaintenanceTask](../models/MaintenanceTask.md) | True | — | All | None |
| MaintenanceTaskId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| NiniteProviderSoftwareId | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| PostInstallScript | [Script](../models/Script.md) | True | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostInstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| PostUninstallScript | [Script](../models/Script.md) | True | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| RebootNeeded | `Boolean` | True | — | All | None |
| Recommended | `Boolean` | True | — | All | None |
| RelativeCacheSourcePath | `Guid` | True | — | All | None |
| RepairScript | [Script](../models/Script.md) | True | — | All | None |
| RepairScriptId | `Nullable`1` | False | — | All | None |
| RepairScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| RepairType | [RepairActionType](../models/RepairActionType.md) | True | — | All | None |
| SoftwareIcon | [Media](../models/Media.md) | True | — | All | None |
| SoftwareIconMediaId | `Nullable`1` | False | — | All | None |
| SoftwarePrerequisites | `ICollection`1` | False | — | All | None |
| SoftwareTableName | `String` | False | — | All | None |
| SoftwareTableNameSearchMode | [SoftwareTableNameSearchMode](../models/SoftwareTableNameSearchMode.md) | True | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| SoftwareVersions | `ICollection`1` | False | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScript | [Script](../models/Script.md) | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UninstallScript | [Script](../models/Script.md) | True | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UpgradeCode | `String` | False | — | All | None |
| UpgradeScript | [Script](../models/Script.md) | True | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UpgradeStrategy | [UpdateActionType](../models/UpdateActionType.md) | True | — | All | None |
| UseDynamicVersions | `Boolean` | True | — | All | None |
| UseSoftwareTableDetection | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
