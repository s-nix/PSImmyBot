---
title: New-ImmyGetPersonResponse
---

# New-ImmyGetPersonResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetPersonResponse` |
| Source | `Cmdlets/NewGetPersonResponse.cs` |
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
| AdditionalComputers | `ICollection`1` | False | — | All | None |
| AzurePrincipalId | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| DisplayName | `String` | False | — | All | None |
| EmailAddress | `String` | False | — | All | None |
| FirstName | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| LastName | `String` | False | — | All | None |
| PrimaryComputers | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |
| User | [GetUserResponse](../models/GetUserResponse.md) | True | — | All | None |
| UserAffinities | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
