---
title: Get-SchedulesRunningScheduleIds
---

# Get-SchedulesRunningScheduleIds

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSchedulesRunningScheduleIds` |
| Source | `Cmdlets/GetSchedulesRunningScheduleIds.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/schedules/running-schedule-ids? |
| Return Type | `object` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/schedules/running-schedule-ids?` and deserializes to `object`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `object` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
