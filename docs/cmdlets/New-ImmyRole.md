---
title: New-ImmyRole
---

# New-ImmyRole

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewRole` |
| Source | `Cmdlets/NewRole.cs` |
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
| ConcurrencyStamp | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| CustomAuditProperties | `ICollection`1` | False | — | All | None |
| Description | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| NormalizedName | `String` | False | — | All | None |
| RoleClaims | `ICollection`1` | False | — | All | None |
| RoleType | [RoleType](../models/RoleType.md) | True | — | All | None |
| RoleTypeId | `Int32` | True | — | All | None |
| TenantRestrictionMode | [TenantRestrictionMode](../models/TenantRestrictionMode.md) | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UserRoles | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
