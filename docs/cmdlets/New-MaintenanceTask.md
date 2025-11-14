---
title: New-MaintenanceTask
---

# New-MaintenanceTask

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
| CreatedByUser | `User` | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DatabaseType | `DatabaseType` | True | — | All | None |
| ExecuteSerially | `Boolean` | True | — | All | None |
| GetEnabled | `Boolean` | True | — | All | None |
| GetScript | `Script` | True | — | All | None |
| GetScriptId | `Nullable`1` | False | — | All | None |
| GetScriptType | `DatabaseType` | True | — | All | None |
| Icon | `Media` | True | — | All | None |
| IconMediaId | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IgnoreDuringAutomaticOnboarding | `Boolean` | True | — | All | None |
| IntegrationTypeId | `Nullable`1` | False | — | All | None |
| IsConfigurationTask | `Boolean` | True | — | All | None |
| MaintenanceTaskCategory | `MaintenanceTaskCategory` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| Name | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| Parameters | `ICollection`1` | False | — | All | None |
| Recommended | `Boolean` | True | — | All | None |
| SetEnabled | `Boolean` | True | — | All | None |
| SetScript | `Script` | True | — | All | None |
| SetScriptId | `Nullable`1` | False | — | All | None |
| SetScriptType | `DatabaseType` | True | — | All | None |
| SupersededByTaskId | `Nullable`1` | False | — | All | None |
| SupersededByTaskMigrationScriptId | `Nullable`1` | False | — | All | None |
| SupersededByTaskMigrationScriptType | `DatabaseType` | True | — | All | None |
| SupersededByTaskType | `DatabaseType` | True | — | All | None |
| TenantRelationships | `ICollection`1` | False | — | All | None |
| TestEnabled | `Boolean` | True | — | All | None |
| TestScript | `Script` | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | `DatabaseType` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | `User` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UseScriptParamBlock | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
