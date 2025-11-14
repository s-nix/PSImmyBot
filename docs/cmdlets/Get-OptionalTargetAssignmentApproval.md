---
title: Get-OptionalTargetAssignmentApproval
---

# Get-OptionalTargetAssignmentApproval

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOptionalTargetAssignmentApproval` |
| Source | `Cmdlets/GetOptionalTargetAssignmentApproval.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/optional-target-assignment-approvals/computer/{ComputerId}? |
| Return Type | `List<GetOptionalTargetAssignmentApprovalResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/optional-target-assignment-approvals/computer/{ComputerId}?` and deserializes to `List<GetOptionalTargetAssignmentApprovalResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<GetOptionalTargetAssignmentApprovalResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
