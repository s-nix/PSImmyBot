---
title: Get-MaintenanceSessionsCancelForSchedule
---

# Get-MaintenanceSessionsCancelForSchedule

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceSessionsCancelForSchedule` |
| Source | `Cmdlets/GetMaintenanceSessionsCancelForSchedule.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-sessions/cancel-for-schedule/{ScheduleId}? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-sessions/cancel-for-schedule/{ScheduleId}?` and deserializes to `byte[]`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScheduleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
