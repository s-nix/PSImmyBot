---
title: New-UpdateOptionalTargetAssignmentApprovalPayload
---

# New-UpdateOptionalTargetAssignmentApprovalPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateOptionalTargetAssignmentApprovalPayload` |
| Source | `Cmdlets/NewUpdateOptionalTargetAssignmentApprovalPayload.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Approved | `TargetAssignmentApprovalStatus` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetAssignmentId | `Int32` | True | — | All | None |
| TargetType | `TargetType` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
