---
title: New-AzureTenantTokenCredentialDetails
---

# New-AzureTenantTokenCredentialDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureTenantTokenCredentialDetails` |
| Source | `Cmdlets/NewAzureTenantTokenCredentialDetails.cs` |
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
| GotAccessTokenFrom | [AccessTokenSource](../models/AccessTokenSource.md) | True | — | All | None |
| OnlyUsePartnerCenterRefresh | `Boolean` | True | — | All | None |
| PartnerPrincipalId | `String` | False | — | All | None |
| ResolvedClientId | `String` | False | — | All | None |
| TenantAzurePermissionLevel | [AzurePermissionLevel2](../models/AzurePermissionLevel2.md) | True | — | All | None |
| TenantPreferredAzureClientId | `String` | False | — | All | None |
| TenantPrincipalId | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
