---
title: New-LatestActionForComputer
---

# New-LatestActionForComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetLatestActionForComputer` |
| Source | `Cmdlets/NewGetLatestActionForComputer.cs` |
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
| ActionType | `MaintenanceActionType` | True | — | All | None |
| AssignmentId | `Nullable`1` | False | — | All | None |
| AssignmentType | `DatabaseType` | True | — | All | None |
| CreatedDate | `Nullable`1` | False | — | All | None |
| DesiredSoftwareState | `DesiredSoftwareState` | True | — | All | None |
| DesiredVersion | `String` | False | — | All | None |
| DetectedVersion | `String` | False | — | All | None |
| EndTime | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceDisplayName | `String` | False | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| MaintenanceTaskMode | `MaintenanceTaskMode` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| PolicyDescription | `String` | False | — | All | None |
| Reason | `MaintenanceActionReason` | True | — | All | None |
| Result | `MaintenanceActionResult` | True | — | All | None |
| ResultReason | `MaintenanceActionResultReason` | True | — | All | None |
| SoftwareActionIdForConfigurationTask | `Nullable`1` | False | — | All | None |
| StartTime | `Nullable`1` | False | — | All | None |
| Status | `MaintenanceActionStatus` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
