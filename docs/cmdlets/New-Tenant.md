---
title: New-Tenant
---

# New-Tenant

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTenant` |
| Source | `Cmdlets/NewTenant.cs` |
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
| AzureTenantLink | [AzureTenantLink](../models/AzureTenantLink.md) | True | — | All | None |
| Brandings | `ICollection`1` | False | — | All | None |
| Computers | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DetectedComputerSoftware | `ICollection`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IsMsp | `Boolean` | True | — | All | None |
| Licenses | `ICollection`1` | False | — | All | None |
| MaintenanceSessions | `ICollection`1` | False | — | All | None |
| MaintenanceTasks | `ICollection`1` | False | — | All | None |
| MarkedForDeletionAtUtc | `Nullable`1` | False | — | All | None |
| Media | `ICollection`1` | False | — | All | None |
| Name | `String` | False | — | All | None |
| OwnedProviderLinks | `ICollection`1` | False | — | All | None |
| OwnedTenants | `ICollection`1` | False | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| ParentTenantId | `Nullable`1` | False | — | All | None |
| Persons | `ICollection`1` | False | — | All | None |
| ProviderClients | `ICollection`1` | False | — | All | None |
| Schedules | `ICollection`1` | False | — | All | None |
| Scripts | `ICollection`1` | False | — | All | None |
| Slug | `String` | False | — | All | None |
| SmtpConfig | [SmtpConfig](../models/SmtpConfig.md) | True | — | All | None |
| Tags | `ICollection`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TenantPreferences | [TenantPreferences](../models/TenantPreferences.md) | True | — | All | None |
| TenantSoftware | `ICollection`1` | False | — | All | None |
| TenantTagAuthorizations | `ICollection`1` | False | — | All | None |
| TenantTags | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| Users | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
