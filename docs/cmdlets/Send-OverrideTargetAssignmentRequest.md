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
| Return Type | `OverrideTargetAssignmentRequest, LocalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/global/{Id}/override?` and deserializes to `OverrideTargetAssignmentRequest, LocalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `OverrideTargetAssignmentRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `OverrideTargetAssignmentRequest, LocalTargetAssignmentResource` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
