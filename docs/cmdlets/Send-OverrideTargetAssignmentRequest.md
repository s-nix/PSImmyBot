---
title: Send-OverrideTargetAssignmentRequest
---

# Send-OverrideTargetAssignmentRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendOverrideTargetAssignmentRequest` |
| Source | `Cmdlets/SendOverrideTargetAssignmentRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/global/{Id}/override? |
| Return Type | [OverrideTargetAssignmentRequest](../models/OverrideTargetAssignmentRequest.md), [LocalTargetAssignmentResource](../models/LocalTargetAssignmentResource.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/global/{Id}/override?` and deserializes to [OverrideTargetAssignmentRequest](../models/OverrideTargetAssignmentRequest.md), [LocalTargetAssignmentResource](../models/LocalTargetAssignmentResource.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [OverrideTargetAssignmentRequest](../models/OverrideTargetAssignmentRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [OverrideTargetAssignmentRequest](../models/OverrideTargetAssignmentRequest.md), [LocalTargetAssignmentResource](../models/LocalTargetAssignmentResource.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
