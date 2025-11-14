---
title: New-ChangeRequest
---

# New-ChangeRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewChangeRequest` |
| Source | `Cmdlets/NewChangeRequest.cs` |
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
| AcknowledgedByUserId | `Nullable`1` | False | — | All | None |
| AcknowledgedByUserName | `String` | False | — | All | None |
| Comments | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | `User` | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| NewValuesJson | `Object` | True | — | All | None |
| ObjectType | `ChangeRequestObjectType` | True | — | All | None |
| Script | `Script` | True | — | All | None |
| ScriptId | `Nullable`1` | False | — | All | None |
| State | `ChangeRequestState` | True | — | All | None |
| TargetAssignment | `TargetAssignment` | True | — | All | None |
| TargetAssignmentId | `Nullable`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | `User` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
