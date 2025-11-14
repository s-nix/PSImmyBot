---
title: Send-UpdateOptionalTargetAssignmentApprovalPayload
---

# Send-UpdateOptionalTargetAssignmentApprovalPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateOptionalTargetAssignmentApprovalPayload` |
| Source | `Cmdlets/SendUpdateOptionalTargetAssignmentApprovalPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/optional-target-assignment-approvals/{Id}? |
| Return Type | `UpdateOptionalTargetAssignmentApprovalPayload, bool` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/optional-target-assignment-approvals/{Id}?` and deserializes to `UpdateOptionalTargetAssignmentApprovalPayload, bool`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateOptionalTargetAssignmentApprovalPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateOptionalTargetAssignmentApprovalPayload, bool` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
