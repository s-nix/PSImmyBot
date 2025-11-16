---
title: Send-ImmySchedulesRunNow
---

# Send-ImmySchedulesRunNow

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSchedulesRunNow` |
| Source | `Cmdlets/SendSchedulesRunNow.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/schedules/{ScheduleId}/run-now? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/schedules/{ScheduleId}/run-now?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScheduleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
