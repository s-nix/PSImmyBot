---
title: New-GetLocalSoftwareResponse
---

# New-GetLocalSoftwareResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetLocalSoftwareResponse` |
| Source | `Cmdlets/NewGetLocalSoftwareResponse.cs` |
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
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| DetectionMethod | `DetectionMethod` | True | — | All | None |
| DetectionScriptId | `Nullable`1` | False | — | All | None |
| DetectionScriptType | `DatabaseType` | True | — | All | None |
| DownloadInstallerScriptId | `Nullable`1` | False | — | All | None |
| DownloadInstallerScriptType | `DatabaseType` | True | — | All | None |
| DynamicVersionsScriptId | `Nullable`1` | False | — | All | None |
| DynamicVersionsScriptType | `DatabaseType` | True | — | All | None |
| Hidden | `Boolean` | True | — | All | None |
| Id | `Nullable`1` | False | — | All | None |
| Identifier | `String` | False | — | All | None |
| InstallOrder | `Int32` | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| InstallScriptType | `DatabaseType` | True | — | All | None |
| LicenseDescription | `String` | False | — | All | None |
| LicenseRequirement | `SoftwareLicenseRequirement` | True | — | All | None |
| LicenseType | `LicenseType` | True | — | All | None |
| MaintenanceTaskId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskType | `DatabaseType` | True | — | All | None |
| Name | `String` | False | — | All | None |
| NiniteProviderSoftwareId | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| OwnerTenantId | `Nullable`1` | False | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostInstallScriptType | `DatabaseType` | True | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptType | `DatabaseType` | True | — | All | None |
| RebootNeeded | `Boolean` | True | — | All | None |
| Recommended | `Boolean` | True | — | All | None |
| RepairScriptId | `Nullable`1` | False | — | All | None |
| RepairScriptType | `DatabaseType` | True | — | All | None |
| RepairType | `RepairActionType` | True | — | All | None |
| SoftwareIcon | `LocalMediaResponse` | True | — | All | None |
| SoftwareIconMediaId | `Nullable`1` | False | — | All | None |
| SoftwarePrerequisites | `ICollection`1` | False | — | All | None |
| SoftwareTableName | `String` | False | — | All | None |
| SoftwareTableNameSearchMode | `SoftwareTableNameSearchMode` | True | — | All | None |
| SoftwareType | `SoftwareType` | True | — | All | None |
| SoftwareVersions | `ICollection`1` | False | — | All | None |
| TenantSoftware | `ICollection`1` | False | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | `DatabaseType` | True | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptType | `DatabaseType` | True | — | All | None |
| UpdatedBy | `String` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |
| UpgradeCode | `String` | False | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeScriptType | `DatabaseType` | True | — | All | None |
| UpgradeStrategy | `UpdateActionType` | True | — | All | None |
| UseDynamicVersions | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
