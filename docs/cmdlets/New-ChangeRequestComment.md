---
title: New-ChangeRequestComment
---

# New-ChangeRequestComment

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewChangeRequestComment` |
| Source | `Cmdlets/NewChangeRequestComment.cs` |
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
| ChangeRequest | `ChangeRequest` | True | — | All | None |
| ChangeRequestId | `Int32` | True | — | All | None |
| Comment | `String` | False | — | All | None |
| CommentedByUsername | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | `User` | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | `User` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
