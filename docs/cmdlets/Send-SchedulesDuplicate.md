---
title: Send-SchedulesDuplicate
---

# Send-SchedulesDuplicate

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSchedulesDuplicate` |
| Source | `Cmdlets/SendSchedulesDuplicate.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/schedules/{ScheduleId}/duplicate? |
| Return Type | `GetScheduleResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/schedules/{ScheduleId}/duplicate?` and deserializes to `GetScheduleResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScheduleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetScheduleResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
