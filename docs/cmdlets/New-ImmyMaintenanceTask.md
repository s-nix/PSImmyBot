---
title: New-ImmyMaintenanceTask
---

# New-ImmyMaintenanceTask

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceTask` |
| Source | `Cmdlets/NewMaintenanceTask.cs` |
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
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| ExecuteSerially | `Boolean` | True | — | All | None |
| GetEnabled | `Boolean` | True | — | All | None |
| GetScript | [Script](../models/Script.md) | True | — | All | None |
| GetScriptId | `Nullable`1` | False | — | All | None |
| GetScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| Icon | [Media](../models/Media.md) | True | — | All | None |
| IconMediaId | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IgnoreDuringAutomaticOnboarding | `Boolean` | True | — | All | None |
| IntegrationTypeId | `Nullable`1` | False | — | All | None |
| IsConfigurationTask | `Boolean` | True | — | All | None |
| MaintenanceTaskCategory | [MaintenanceTaskCategory](../models/MaintenanceTaskCategory.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| Parameters | `ICollection`1` | False | — | All | None |
| Recommended | `Boolean` | True | — | All | None |
| SetEnabled | `Boolean` | True | — | All | None |
| SetScript | [Script](../models/Script.md) | True | — | All | None |
| SetScriptId | `Nullable`1` | False | — | All | None |
| SetScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| SupersededByTaskId | `Nullable`1` | False | — | All | None |
| SupersededByTaskMigrationScriptId | `Nullable`1` | False | — | All | None |
| SupersededByTaskMigrationScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| SupersededByTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| TenantRelationships | `ICollection`1` | False | — | All | None |
| TestEnabled | `Boolean` | True | — | All | None |
| TestScript | [Script](../models/Script.md) | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UseScriptParamBlock | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
