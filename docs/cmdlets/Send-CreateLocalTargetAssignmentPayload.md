---
title: Send-CreateLocalTargetAssignmentPayload
---

# Send-CreateLocalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalTargetAssignmentPayload` |
| Source | `Cmdlets/SendCreateLocalTargetAssignmentPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments? |
| Return Type | `CreateLocalTargetAssignmentPayload, LocalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments?` and deserializes to `CreateLocalTargetAssignmentPayload, LocalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateLocalTargetAssignmentPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateLocalTargetAssignmentPayload, LocalTargetAssignmentResource` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
