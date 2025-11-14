---
title: New-SessionPhase
---

# New-SessionPhase

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSessionPhase` |
| Source | `Cmdlets/NewSessionPhase.cs` |
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
| ActionProgressPhaseName | `ActionProgressPhaseName` | True | — | All | None |
| DateCompletedUtc | `Nullable`1` | False | — | All | None |
| DateStartedUtc | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| Logs | `ICollection`1` | False | — | All | None |
| MaintenanceAction | `MaintenanceAction` | True | — | All | None |
| MaintenanceActionId | `Nullable`1` | False | — | All | None |
| MaintenanceSession | `MaintenanceSession` | True | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| MaintenanceSessionStage | `MaintenanceSessionStage` | True | — | All | None |
| MaintenanceSessionStageId | `Int32` | True | — | All | None |
| PhaseName | `String` | False | — | All | None |
| ProgressCompleted | `Boolean` | True | — | All | None |
| ProgressPercentComplete | `Nullable`1` | False | — | All | None |
| ProgressStatus | `String` | False | — | All | None |
| Status | `SessionPhaseStatus` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
