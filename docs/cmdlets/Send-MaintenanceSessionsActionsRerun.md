---
title: Send-MaintenanceSessionsActionsRerun
---

# Send-MaintenanceSessionsActionsRerun

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMaintenanceSessionsActionsRerun` |
| Source | `Cmdlets/SendMaintenanceSessionsActionsRerun.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-sessions/{SessionId}/actions/{ActionId}/rerun? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-sessions/{SessionId}/actions/{ActionId}/rerun?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ActionId | `Int32` | True | — | All | None |
| SessionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
