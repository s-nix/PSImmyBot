---
title: Push-ImmyUpdateGlobalTargetAssignmentPayload
---

# Push-ImmyUpdateGlobalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateGlobalTargetAssignmentPayload` |
| Source | `Cmdlets/PushUpdateGlobalTargetAssignmentPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/target-assignments/global/{Id}? |
| Return Type | [UpdateGlobalTargetAssignmentPayload](../models/UpdateGlobalTargetAssignmentPayload.md), [GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/target-assignments/global/{Id}?` and deserializes to [UpdateGlobalTargetAssignmentPayload](../models/UpdateGlobalTargetAssignmentPayload.md), [GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateGlobalTargetAssignmentPayload](../models/UpdateGlobalTargetAssignmentPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateGlobalTargetAssignmentPayload](../models/UpdateGlobalTargetAssignmentPayload.md), [GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md) records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
