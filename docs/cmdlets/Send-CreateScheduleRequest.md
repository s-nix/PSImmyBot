---
title: Send-CreateScheduleRequest
---

# Send-CreateScheduleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateScheduleRequest` |
| Source | `Cmdlets/SendCreateScheduleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/schedules? |
| Return Type | [CreateScheduleRequest](../models/CreateScheduleRequest.md), [GetScheduleResponse](../models/GetScheduleResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/schedules?` and deserializes to [CreateScheduleRequest](../models/CreateScheduleRequest.md), [GetScheduleResponse](../models/GetScheduleResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateScheduleRequest](../models/CreateScheduleRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateScheduleRequest](../models/CreateScheduleRequest.md), [GetScheduleResponse](../models/GetScheduleResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
