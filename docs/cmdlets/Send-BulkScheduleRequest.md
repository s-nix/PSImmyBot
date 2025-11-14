---
title: Send-BulkScheduleRequest
---

# Send-BulkScheduleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBulkScheduleRequest` |
| Source | `Cmdlets/SendBulkScheduleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/schedules/bulk-cancel? |
| Return Type | `BulkScheduleRequest, List<BulkScheduleOperationResult>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/schedules/bulk-cancel?` and deserializes to `BulkScheduleRequest, List<BulkScheduleOperationResult>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `BulkScheduleRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `BulkScheduleRequest, List<BulkScheduleOperationResult>` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
