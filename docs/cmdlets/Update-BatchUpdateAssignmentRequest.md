---
title: Update-BatchUpdateAssignmentRequest
---

# Update-BatchUpdateAssignmentRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateBatchUpdateAssignmentRequest` |
| Source | `Cmdlets/UpdateBatchUpdateAssignmentRequest.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/target-assignments/batch-update? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/target-assignments/batch-update?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BatchUpdateAssignmentRequest](../models/BatchUpdateAssignmentRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
