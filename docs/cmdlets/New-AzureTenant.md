---
title: New-AzureTenant
---

# New-AzureTenant

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureTenant` |
| Source | `Cmdlets/NewAzureTenant.cs` |
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
| AzureTenantLinks | `ICollection`1` | False | — | All | None |
| AzureTenantType | `AzTenantType` | True | — | All | None |
| ConsentDetails | `AzureTenantConsentDetails` | True | — | All | None |
| InfoSyncedFromAzure | `AzureTenantInfo` | True | — | All | None |
| LastGetTenantInfoSyncResult | `AzureSyncResult` | True | — | All | None |
| LastGetUsersSyncResult | `AzureSyncResult` | True | — | All | None |
| ParentPartner | `AzureTenant` | True | — | All | None |
| PartnerPrincipalId | `String` | False | — | All | None |
| PrincipalId | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
