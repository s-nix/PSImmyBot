---
title: New-TargetAssignmentNotes
---

# New-TargetAssignmentNotes

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTargetAssignmentNotes` |
| Source | `Cmdlets/NewTargetAssignmentNotes.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Notes | `String` | False | — | All | None |
| TargetAssignment | `TargetAssignment` | True | — | All | None |
| TargetAssignmentId | `Int32` | True | — | All | None |
| UpdatedByName | `String` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
