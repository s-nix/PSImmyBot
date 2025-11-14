---
title: New-IPermissionMetadata
---

# New-IPermissionMetadata

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewIPermissionMetadata` |
| Source | `Cmdlets/NewIPermissionMetadata.cs` |
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
| AllowClaim | `String` | False | — | All | None |
| Category | [PermissionCategory](../models/PermissionCategory.md) | True | — | All | None |
| Claim | `String` | False | — | All | None |
| DenyClaim | `String` | False | — | All | None |
| Dependencies | `ICollection`1` | False | — | All | None |
| Description | `String` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| HasGreatPower | `Boolean` | True | — | All | None |
| Id | `String` | False | — | All | None |
| IsMspOnly | `Boolean` | True | — | All | None |
| IsSystemManaged | `Boolean` | True | — | All | None |
| PermissionName | `String` | False | — | All | None |
| ResourceClaimType | `String` | False | — | All | None |
| SortOrder | `Int32` | True | — | All | None |
| Subject | [ISubjectMetadata](../models/ISubjectMetadata.md) | True | — | All | None |
| SubjectClaimType | `String` | False | — | All | None |
| TenantClaimType | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
