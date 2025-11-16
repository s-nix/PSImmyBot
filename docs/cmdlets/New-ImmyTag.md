---
title: New-ImmyTag
---

# New-ImmyTag

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTag` |
| Source | `Cmdlets/NewTag.cs` |
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
| Color | `String` | False | — | All | None |
| Computers | `ICollection`1` | False | — | All | None |
| ComputerTags | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Description | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| Persons | `ICollection`1` | False | — | All | None |
| PersonTags | `ICollection`1` | False | — | All | None |
| TenantRelationships | `ICollection`1` | False | — | All | None |
| Tenants | `ICollection`1` | False | — | All | None |
| TenantTags | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
