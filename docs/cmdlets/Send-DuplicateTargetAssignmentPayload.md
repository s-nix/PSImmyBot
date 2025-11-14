---
title: Send-DuplicateTargetAssignmentPayload
---

# Send-DuplicateTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDuplicateTargetAssignmentPayload` |
| Source | `Cmdlets/SendDuplicateTargetAssignmentPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/duplicates? |
| Return Type | [DuplicateTargetAssignmentPayload](../models/DuplicateTargetAssignmentPayload.md), [TargetAssignmentDuplicateResponse](../models/TargetAssignmentDuplicateResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/duplicates?` and deserializes to [DuplicateTargetAssignmentPayload](../models/DuplicateTargetAssignmentPayload.md), [TargetAssignmentDuplicateResponse](../models/TargetAssignmentDuplicateResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [DuplicateTargetAssignmentPayload](../models/DuplicateTargetAssignmentPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [DuplicateTargetAssignmentPayload](../models/DuplicateTargetAssignmentPayload.md), [TargetAssignmentDuplicateResponse](../models/TargetAssignmentDuplicateResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
