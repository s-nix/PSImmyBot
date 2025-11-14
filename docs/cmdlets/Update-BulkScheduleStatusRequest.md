---
title: Update-BulkScheduleStatusRequest
---

# Update-BulkScheduleStatusRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateBulkScheduleStatusRequest` |
| Source | `Cmdlets/UpdateBulkScheduleStatusRequest.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/schedules/bulk-update-status? |
| Return Type | [BulkScheduleStatusRequest](../models/BulkScheduleStatusRequest.md), List<[BulkScheduleOperationResult](../models/BulkScheduleOperationResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/schedules/bulk-update-status?` and deserializes to [BulkScheduleStatusRequest](../models/BulkScheduleStatusRequest.md), List<[BulkScheduleOperationResult](../models/BulkScheduleOperationResult.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BulkScheduleStatusRequest](../models/BulkScheduleStatusRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [BulkScheduleStatusRequest](../models/BulkScheduleStatusRequest.md), List<[BulkScheduleOperationResult](../models/BulkScheduleOperationResult.md)> records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
