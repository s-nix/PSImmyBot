---
title: Send-ImmyBulkScheduleRequest
---

# Send-ImmyBulkScheduleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBulkScheduleRequest` |
| Source | `Cmdlets/SendBulkScheduleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/schedules/bulk-cancel? |
| Return Type | [BulkScheduleRequest](../models/BulkScheduleRequest.md), List<[BulkScheduleOperationResult](../models/BulkScheduleOperationResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/schedules/bulk-cancel?` and deserializes to [BulkScheduleRequest](../models/BulkScheduleRequest.md), List<[BulkScheduleOperationResult](../models/BulkScheduleOperationResult.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BulkScheduleRequest](../models/BulkScheduleRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [BulkScheduleRequest](../models/BulkScheduleRequest.md), List<[BulkScheduleOperationResult](../models/BulkScheduleOperationResult.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
