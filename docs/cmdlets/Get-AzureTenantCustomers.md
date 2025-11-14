---
title: Get-AzureTenantCustomers
---

# Get-AzureTenantCustomers

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAzureTenantCustomers` |
| Source | `Cmdlets/GetAzureTenantCustomers.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/azure/partner-tenant-customers/{PartnerPrincipalId}? |
| Return Type | `List<AzureTenantCustomersResult>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/azure/partner-tenant-customers/{PartnerPrincipalId}?` and deserializes to `List<AzureTenantCustomersResult>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PartnerPrincipalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<AzureTenantCustomersResult>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
