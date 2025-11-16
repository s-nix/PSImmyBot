---
title: New-ImmyMaintenanceAction
---

# New-ImmyMaintenanceAction

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceAction` |
| Source | `Cmdlets/NewMaintenanceAction.cs` |
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
| ActionReason | [MaintenanceActionReason](../models/MaintenanceActionReason.md) | True | — | All | None |
| ActionResult | [MaintenanceActionResult](../models/MaintenanceActionResult.md) | True | — | All | None |
| ActionResultReason | [MaintenanceActionResultReason](../models/MaintenanceActionResultReason.md) | True | — | All | None |
| ActionResultReasonMessage | `String` | False | — | All | None |
| ActionStatus | [MaintenanceActionStatus](../models/MaintenanceActionStatus.md) | True | — | All | None |
| ActionType | [MaintenanceActionType](../models/MaintenanceActionType.md) | True | — | All | None |
| Activities | `ICollection`1` | False | — | All | None |
| AssignmentId | `Nullable`1` | False | — | All | None |
| AssignmentType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Dependents | `ICollection`1` | False | — | All | None |
| DependsOn | `ICollection`1` | False | — | All | None |
| DependsOnActions | `ICollection`1` | False | — | All | None |
| Description | `String` | False | — | All | None |
| DesiredSoftwareState | [DesiredSoftwareState](../models/DesiredSoftwareState.md) | True | — | All | None |
| DesiredVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| DesiredVersionString | `String` | False | — | All | None |
| DetectedVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| DetectedVersionString | `String` | False | — | All | None |
| EndTime | `DateTimeOffset` | True | — | All | None |
| HasDeterminedDesiredVersion | `Boolean` | True | — | All | None |
| HasDeterminedDetectedVersion | `Boolean` | True | — | All | None |
| HasDeterminedTaskGetResult | `Boolean` | True | — | All | None |
| HasDeterminedTaskTestResult | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IsComplete | `Boolean` | True | — | All | None |
| IsStarted | `Boolean` | True | — | All | None |
| LastAction | `String` | False | — | All | None |
| LastActionResult | `String` | False | — | All | None |
| LastActionRmmComputerId | `String` | False | — | All | None |
| LastActionType | [ScriptLanguage](../models/ScriptLanguage.md) | True | — | All | None |
| Logs | `ICollection`1` | False | — | All | None |
| MaintenanceDisplayName | `String` | False | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceSession | [MaintenanceSession](../models/MaintenanceSession.md) | True | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| MaintenanceTaskGetResult | `String` | False | — | All | None |
| MaintenanceTaskMode | [MaintenanceTaskMode](../models/MaintenanceTaskMode.md) | True | — | All | None |
| MaintenanceTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Parameters | `String` | False | — | All | None |
| ParentId | `Nullable`1` | False | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| Phases | `ICollection`1` | False | — | All | None |
| PolicyDescription | `String` | False | — | All | None |
| PostMaintenanceTest | `String` | False | — | All | None |
| PostMaintenanceTestResult | `Nullable`1` | False | — | All | None |
| PostMaintenanceTestResultMessage | `String` | False | — | All | None |
| PostMaintenanceTestType | `Nullable`1` | False | — | All | None |
| ScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| SoftwareActionIdForConfigurationTask | `Nullable`1` | False | — | All | None |
| SoftwareActionIdForConfigurationTaskOrId | `Int32` | True | — | All | None |
| SoftwareProviderType | [SoftwareProviderType](../models/SoftwareProviderType.md) | True | — | All | None |
| SoftwareTableRegexString | `String` | False | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| StartTime | `DateTimeOffset` | True | — | All | None |
| TaskTestResult | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UsesManualProgressControl | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
