---
title: Send-ImmyPreconsentCustomerTenantsRequest
---

# Send-ImmyPreconsentCustomerTenantsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendPreconsentCustomerTenantsRequest` |
| Source | `Cmdlets/SendPreconsentCustomerTenantsRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/azure/preconsent-customer-tenants? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/azure/preconsent-customer-tenants?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [PreconsentCustomerTenantsRequest](../models/PreconsentCustomerTenantsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
