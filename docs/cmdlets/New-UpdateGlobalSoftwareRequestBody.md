---
title: New-UpdateGlobalSoftwareRequestBody
---

# New-UpdateGlobalSoftwareRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateGlobalSoftwareRequestBody` |
| Source | `Cmdlets/NewUpdateGlobalSoftwareRequestBody.cs` |
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
| DetectionMethod | [DetectionMethod](../models/DetectionMethod.md) | True | — | All | None |
| DetectionScriptId | `Nullable`1` | False | — | All | None |
| DownloadInstallerScriptId | `Nullable`1` | False | — | All | None |
| DynamicVersionsScriptId | `Nullable`1` | False | — | All | None |
| Hidden | `Boolean` | True | — | All | None |
| InstallOrder | `Int32` | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| LicenseDescription | `String` | False | — | All | None |
| LicenseRequirement | [SoftwareLicenseRequirement](../models/SoftwareLicenseRequirement.md) | True | — | All | None |
| LicenseType | [LicenseType](../models/LicenseType.md) | True | — | All | None |
| MaintenanceTaskId | `Nullable`1` | False | — | All | None |
| Name | `String` | False | — | All | None |
| NiniteProviderSoftwareId | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| RebootNeeded | `Boolean` | True | — | All | None |
| Recommended | `Boolean` | True | — | All | None |
| RepairScriptId | `Nullable`1` | False | — | All | None |
| RepairType | `Nullable`1` | False | — | All | None |
| SoftwareIconMediaId | `Nullable`1` | False | — | All | None |
| SoftwareId | `Int32` | True | — | All | None |
| SoftwarePrerequisites | `ICollection`1` | False | — | All | None |
| SoftwareTableName | `String` | False | — | All | None |
| SoftwareTableNameSearchMode | [SoftwareTableNameSearchMode](../models/SoftwareTableNameSearchMode.md) | True | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UpgradeCode | `String` | False | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeStrategy | [UpdateActionType](../models/UpdateActionType.md) | True | — | All | None |
| UseDynamicVersions | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
