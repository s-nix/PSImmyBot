---
title: New-ImmySessionLog
---

# New-ImmySessionLog

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSessionLog` |
| Source | `Cmdlets/NewSessionLog.cs` |
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
| Id | `Int32` | True | — | All | None |
| ImmediateUser | `Nullable`1` | False | — | All | None |
| IsPrimary | `Boolean` | True | — | All | None |
| MaintenanceAction | [MaintenanceAction](../models/MaintenanceAction.md) | True | — | All | None |
| MaintenanceActionId | `Nullable`1` | False | — | All | None |
| MaintenanceActionStatus | [MaintenanceActionStatus](../models/MaintenanceActionStatus.md) | True | — | All | None |
| MaintenanceSession | [MaintenanceSession](../models/MaintenanceSession.md) | True | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| MaintenanceSessionStage | [MaintenanceSessionStage](../models/MaintenanceSessionStage.md) | True | — | All | None |
| MaintenanceSessionStageId | `Nullable`1` | False | — | All | None |
| Message | `String` | False | — | All | None |
| ParamBlockParameters | `IDictionary`2` | False | — | All | None |
| ProgressActivity | `String` | False | — | All | None |
| ProgressCompleted | `Boolean` | True | — | All | None |
| ProgressCorrelationId | `Nullable`1` | False | — | All | None |
| ProgressCurrentOperation | `String` | False | — | All | None |
| ProgressPercentComplete | `Nullable`1` | False | — | All | None |
| ProgressSecondsRemaining | `Nullable`1` | False | — | All | None |
| ProgressStatus | `String` | False | — | All | None |
| Script | `String` | False | — | All | None |
| ScriptExecutionContext | [ScriptExecutionContext](../models/ScriptExecutionContext.md) | True | — | All | None |
| ScriptId | `Nullable`1` | False | — | All | None |
| ScriptLanguage | [ScriptLanguage](../models/ScriptLanguage.md) | True | — | All | None |
| ScriptOutput | `String` | False | — | All | None |
| ScriptParameters | `IDictionary`2` | False | — | All | None |
| ScriptTimeout | `Nullable`1` | False | — | All | None |
| ScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| SessionLogType | [SessionLogType](../models/SessionLogType.md) | True | — | All | None |
| SessionPhase | [SessionPhase](../models/SessionPhase.md) | True | — | All | None |
| SessionPhaseId | `Nullable`1` | False | — | All | None |
| Time | `DateTimeOffset` | True | — | All | None |
| UpdatedTime | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
