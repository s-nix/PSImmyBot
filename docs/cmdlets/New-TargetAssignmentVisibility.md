---
title: New-TargetAssignmentVisibility
---

# New-TargetAssignmentVisibility

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTargetAssignmentVisibility` |
| Source | `Cmdlets/NewTargetAssignmentVisibility.cs` |
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
| SelfService | `Boolean` | True | — | All | None |
| TargetAssignment | `TargetAssignment` | True | — | All | None |
| TargetAssignmentId | `Int32` | True | — | All | None |
| TechnicianPod | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
