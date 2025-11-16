---
title: New-ImmyCreateTenantRequestBody
---

# New-ImmyCreateTenantRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCreateTenantRequestBody` |
| Source | `Cmdlets/NewCreateTenantRequestBody.cs` |
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
| IsMsp | `Boolean` | True | — | All | None |
| LimitToDomains | `ICollection`1` | False | — | All | None |
| Name | `String` | False | — | All | None |
| OwnerTenantId | `Int32` | True | — | All | None |
| ParentTenantId | `Nullable`1` | False | — | All | None |
| PartnerPrincipalId | `String` | False | — | All | None |
| PrincipalId | `String` | False | — | All | None |
| Slug | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
