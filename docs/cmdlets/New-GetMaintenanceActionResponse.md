---
title: New-GetMaintenanceActionResponse
---

# New-GetMaintenanceActionResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetMaintenanceActionResponse` |
| Source | `Cmdlets/NewGetMaintenanceActionResponse.cs` |
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
| ActionType | [MaintenanceActionType](../models/MaintenanceActionType.md) | True | — | All | None |
| ActionTypeName | `String` | False | — | All | None |
| AssignmentId | `Nullable`1` | False | — | All | None |
| AssignmentType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| ComputerName | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| DependentsNames | `ICollection`1` | False | — | All | None |
| DependsOnNames | `ICollection`1` | False | — | All | None |
| Description | `String` | False | — | All | None |
| DesiredSoftwareState | [DesiredSoftwareState](../models/DesiredSoftwareState.md) | True | — | All | None |
| DesiredVersionString | `String` | False | — | All | None |
| DetectedVersionString | `String` | False | — | All | None |
| EndTime | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IsComputerOnline | `Boolean` | True | — | All | None |
| MaintenanceDisplayName | `String` | False | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| MaintenanceTaskGetResult | `String` | False | — | All | None |
| MaintenanceTaskMode | [MaintenanceTaskMode](../models/MaintenanceTaskMode.md) | True | — | All | None |
| MaintenanceTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| MaintenanceTypeName | `String` | False | — | All | None |
| ParentId | `Nullable`1` | False | — | All | None |
| PolicyDescription | `String` | False | — | All | None |
| PostMaintenanceTest | `String` | False | — | All | None |
| PostMaintenanceTestResult | `Nullable`1` | False | — | All | None |
| PostMaintenanceTestResultMessage | `String` | False | — | All | None |
| PostMaintenanceTestType | `Nullable`1` | False | — | All | None |
| Reason | [MaintenanceActionReason](../models/MaintenanceActionReason.md) | True | — | All | None |
| Result | [MaintenanceActionResult](../models/MaintenanceActionResult.md) | True | — | All | None |
| ResultName | `String` | False | — | All | None |
| ResultReason | [MaintenanceActionResultReason](../models/MaintenanceActionResultReason.md) | True | — | All | None |
| ResultReasonMessage | `String` | False | — | All | None |
| SoftwareActionIdForConfigurationTask | `Nullable`1` | False | — | All | None |
| SoftwareProviderType | [SoftwareProviderType](../models/SoftwareProviderType.md) | True | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| StartTime | `DateTimeOffset` | True | — | All | None |
| Status | [MaintenanceActionStatus](../models/MaintenanceActionStatus.md) | True | — | All | None |
| StatusName | `String` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TenantName | `String` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
