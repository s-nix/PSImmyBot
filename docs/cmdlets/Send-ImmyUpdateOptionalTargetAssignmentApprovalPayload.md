---
title: Send-ImmyUpdateOptionalTargetAssignmentApprovalPayload
---

# Send-ImmyUpdateOptionalTargetAssignmentApprovalPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateOptionalTargetAssignmentApprovalPayload` |
| Source | `Cmdlets/SendUpdateOptionalTargetAssignmentApprovalPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/optional-target-assignment-approvals/{Id}? |
| Return Type | [UpdateOptionalTargetAssignmentApprovalPayload](../models/UpdateOptionalTargetAssignmentApprovalPayload.md), bool |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/optional-target-assignment-approvals/{Id}?` and deserializes to [UpdateOptionalTargetAssignmentApprovalPayload](../models/UpdateOptionalTargetAssignmentApprovalPayload.md), bool.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateOptionalTargetAssignmentApprovalPayload](../models/UpdateOptionalTargetAssignmentApprovalPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateOptionalTargetAssignmentApprovalPayload](../models/UpdateOptionalTargetAssignmentApprovalPayload.md), bool records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
