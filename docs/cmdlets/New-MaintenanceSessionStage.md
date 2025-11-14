---
title: New-MaintenanceSessionStage
---

# New-MaintenanceSessionStage

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceSessionStage` |
| Source | `Cmdlets/NewMaintenanceSessionStage.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| JobId | `String` | False | — | All | None |
| Logs | `ICollection`1` | False | — | All | None |
| MaintenanceSession | [MaintenanceSession](../models/MaintenanceSession.md) | True | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| Phases | `ICollection`1` | False | — | All | None |
| StageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| Type | [SessionStageType](../models/SessionStageType.md) | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
