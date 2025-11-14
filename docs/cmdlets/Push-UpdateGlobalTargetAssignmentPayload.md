---
title: Push-UpdateGlobalTargetAssignmentPayload
---

# Push-UpdateGlobalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateGlobalTargetAssignmentPayload` |
| Source | `Cmdlets/PushUpdateGlobalTargetAssignmentPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/target-assignments/global/{Id}? |
| Return Type | `UpdateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/target-assignments/global/{Id}?` and deserializes to `UpdateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateGlobalTargetAssignmentPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
