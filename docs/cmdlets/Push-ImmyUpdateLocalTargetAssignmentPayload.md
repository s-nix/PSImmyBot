---
title: Push-ImmyUpdateLocalTargetAssignmentPayload
---

# Push-ImmyUpdateLocalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateLocalTargetAssignmentPayload` |
| Source | `Cmdlets/PushUpdateLocalTargetAssignmentPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/target-assignments/{Id}? |
| Return Type | [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md), [LocalTargetAssignmentResource](../models/LocalTargetAssignmentResource.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/target-assignments/{Id}?` and deserializes to [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md), [LocalTargetAssignmentResource](../models/LocalTargetAssignmentResource.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md), [LocalTargetAssignmentResource](../models/LocalTargetAssignmentResource.md) records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
