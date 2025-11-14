---
title: New-AzureTenantResponse
---

# New-AzureTenantResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureTenantResponse` |
| Source | `Cmdlets/NewAzureTenantResponse.cs` |
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
| AzureTenantType | [AzTenantType](../models/AzTenantType.md) | True | — | All | None |
| ConsentDetails | [AzureTenantConsentDetails](../models/AzureTenantConsentDetails.md) | True | — | All | None |
| InfoSyncedFromAzure | [AzureTenantInfo](../models/AzureTenantInfo.md) | True | — | All | None |
| LastGetTenantInfoSyncResult | [AzureSyncResult](../models/AzureSyncResult.md) | True | — | All | None |
| LastGetUsersSyncResult | [AzureSyncResult](../models/AzureSyncResult.md) | True | — | All | None |
| PartnerPrincipalId | `String` | False | — | All | None |
| PrincipalId | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
