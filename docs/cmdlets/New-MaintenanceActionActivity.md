---
title: New-MaintenanceActionActivity
---

# New-MaintenanceActionActivity

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceActionActivity` |
| Source | `Cmdlets/NewMaintenanceActionActivity.cs` |
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
| Activity | `String` | False | — | All | None |
| ActivityId | `String` | False | — | All | None |
| Completed | `Nullable`1` | False | — | All | None |
| CurrentOperation | `String` | False | — | All | None |
| DateUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceAction | [MaintenanceAction](../models/MaintenanceAction.md) | True | — | All | None |
| MaintenanceActionId | `Int32` | True | — | All | None |
| MaintenanceSession | [MaintenanceSession](../models/MaintenanceSession.md) | True | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| ParentId | `String` | False | — | All | None |
| PercentComplete | `Nullable`1` | False | — | All | None |
| ScriptName | `String` | False | — | All | None |
| SecondsRemaining | `Nullable`1` | False | — | All | None |
| SourceId | `String` | False | — | All | None |
| Status | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
