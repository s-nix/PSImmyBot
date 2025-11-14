---
title: Send-SchedulesCancel
---

# Send-SchedulesCancel

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSchedulesCancel` |
| Source | `Cmdlets/SendSchedulesCancel.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/schedules/{ScheduleId}/cancel? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/schedules/{ScheduleId}/cancel?`.

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
