---
title: Send-CreateGlobalTargetAssignmentPayload
---

# Send-CreateGlobalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalTargetAssignmentPayload` |
| Source | `Cmdlets/SendCreateGlobalTargetAssignmentPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/global/create? |
| Return Type | `CreateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/global/create?` and deserializes to `CreateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateGlobalTargetAssignmentPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
