---
title: Send-ImmyCreateGlobalTargetAssignmentPayload
---

# Send-ImmyCreateGlobalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalTargetAssignmentPayload` |
| Source | `Cmdlets/SendCreateGlobalTargetAssignmentPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/global/create? |
| Return Type | [CreateGlobalTargetAssignmentPayload](../models/CreateGlobalTargetAssignmentPayload.md), [GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/global/create?` and deserializes to [CreateGlobalTargetAssignmentPayload](../models/CreateGlobalTargetAssignmentPayload.md), [GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateGlobalTargetAssignmentPayload](../models/CreateGlobalTargetAssignmentPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateGlobalTargetAssignmentPayload](../models/CreateGlobalTargetAssignmentPayload.md), [GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
