---
title: New-AccessRequest
---

# New-AccessRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAccessRequest` |
| Source | `Cmdlets/NewAccessRequest.cs` |
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
| AcknowledgedByUser | `User` | True | — | All | None |
| AcknowledgedByUserId | `Nullable`1` | False | — | All | None |
| DateAcknowledgedUtc | `Nullable`1` | False | — | All | None |
| DateRequestedUtc | `DateTimeOffset` | True | — | All | None |
| ExpirationTime | `ExpirationTime` | True | — | All | None |
| Granted | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IsAdmin | `Nullable`1` | False | — | All | None |
| Message | `String` | False | — | All | None |
| Person | `Person` | True | — | All | None |
| PersonId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
