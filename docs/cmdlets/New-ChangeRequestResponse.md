---
title: New-ChangeRequestResponse
---

# New-ChangeRequestResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewChangeRequestResponse` |
| Source | `Cmdlets/NewChangeRequestResponse.cs` |
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
| CreatedByUserName | `String` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| NewValuesJson | `Object` | True | — | All | None |
| ObjectType | `ChangeRequestObjectType` | True | — | All | None |
| ScriptId | `Nullable`1` | False | — | All | None |
| State | `ChangeRequestState` | True | — | All | None |
| TargetAssignmentId | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
