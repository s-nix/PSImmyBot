---
title: Get-Schedule
---

# Get-Schedule

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSchedule` |
| Source | `Cmdlets/GetSchedule.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/schedules/{ScheduleId}? |
| Return Type | `GetScheduleResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/schedules/{ScheduleId}?` and deserializes to `GetScheduleResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScheduleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetScheduleResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
