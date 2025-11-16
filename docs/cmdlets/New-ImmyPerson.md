---
title: New-ImmyPerson
---

# New-ImmyPerson

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewPerson` |
| Source | `Cmdlets/NewPerson.cs` |
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
| AccessRequests | `ICollection`1` | False | — | All | None |
| AdditionalComputers | `ICollection`1` | False | — | All | None |
| AzurePrincipalId | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DetectedComputerSoftware | `ICollection`1` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| EmailAddress | `String` | False | — | All | None |
| FirstName | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| LastName | `String` | False | — | All | None |
| OnPremisesSecurityIdentifier | `String` | False | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| PersonSessions | `ICollection`1` | False | — | All | None |
| PersonTags | `ICollection`1` | False | — | All | None |
| PrimaryComputers | `ICollection`1` | False | — | All | None |
| Tags | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| User | [User](../models/User.md) | True | — | All | None |
| UserAffinities | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
