---
title: New-ImmyGetTenantResponse
---

# New-ImmyGetTenantResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetTenantResponse` |
| Source | `Cmdlets/NewGetTenantResponse.cs` |
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
| Active | `Boolean` | True | — | All | None |
| AzureTenantLink | [AzureTenantLinkResponse](../models/AzureTenantLinkResponse.md) | True | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IsMsp | `Boolean` | True | — | All | None |
| MarkedForDeletionAtUtc | `Nullable`1` | False | — | All | None |
| Name | `String` | False | — | All | None |
| OwnerTenantId | `Nullable`1` | False | — | All | None |
| ParentTenantId | `Nullable`1` | False | — | All | None |
| Slug | `String` | False | — | All | None |
| TenantTagIds | `ICollection`1` | False | — | All | None |
| TenantTagNames | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
