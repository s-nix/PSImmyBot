---
title: New-ImmyUpdateAzureTenantLinkRequest
---

# New-ImmyUpdateAzureTenantLinkRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateAzureTenantLinkRequest` |
| Source | `Cmdlets/NewUpdateAzureTenantLinkRequest.cs` |
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
| LimitToDomains | `ICollection`1` | False | — | All | None |
| PartnerPrincipalId | `String` | False | — | All | None |
| PrincipalId | `String` | False | — | All | None |
| RemoveCustomersSyncedUsers | `Boolean` | True | — | All | None |
| RemoveSyncedUsers | `Boolean` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UnlinkCustomers | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
