---
title: Send-ImmyMaintenanceSessionsRerun
---

# Send-ImmyMaintenanceSessionsRerun

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMaintenanceSessionsRerun` |
| Source | `Cmdlets/SendMaintenanceSessionsRerun.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-sessions/{SessionId}/rerun? |
| Return Type | `int` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-sessions/{SessionId}/rerun?` and deserializes to `int`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SessionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `int` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
