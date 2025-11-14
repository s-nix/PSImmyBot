---
title: Push-UpdateScheduleRequest
---

# Push-UpdateScheduleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateScheduleRequest` |
| Source | `Cmdlets/PushUpdateScheduleRequest.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/schedules/{ScheduleId}? |
| Return Type | `UpdateScheduleRequest, GetScheduleResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/schedules/{ScheduleId}?` and deserializes to `UpdateScheduleRequest, GetScheduleResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `UpdateScheduleRequest` | True | — | All | None |
| ScheduleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateScheduleRequest, GetScheduleResponse` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
