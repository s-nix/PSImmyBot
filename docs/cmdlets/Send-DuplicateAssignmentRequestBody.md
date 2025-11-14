---
title: Send-DuplicateAssignmentRequestBody
---

# Send-DuplicateAssignmentRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDuplicateAssignmentRequestBody` |
| Source | `Cmdlets/SendDuplicateAssignmentRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/duplicate? |
| Return Type | [DuplicateAssignmentRequestBody](../models/DuplicateAssignmentRequestBody.md), int |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/duplicate?` and deserializes to [DuplicateAssignmentRequestBody](../models/DuplicateAssignmentRequestBody.md), int.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [DuplicateAssignmentRequestBody](../models/DuplicateAssignmentRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [DuplicateAssignmentRequestBody](../models/DuplicateAssignmentRequestBody.md), int records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
