---
title: Push-UpdateLocalTargetAssignmentPayload
---

# Push-UpdateLocalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateLocalTargetAssignmentPayload` |
| Source | `Cmdlets/PushUpdateLocalTargetAssignmentPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/target-assignments/{Id}? |
| Return Type | `UpdateLocalTargetAssignmentPayload, LocalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/target-assignments/{Id}?` and deserializes to `UpdateLocalTargetAssignmentPayload, LocalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateLocalTargetAssignmentPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateLocalTargetAssignmentPayload, LocalTargetAssignmentResource` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
