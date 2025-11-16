---
title: Get-ImmyAzureErrorLogItemsForTenant
---

# Get-ImmyAzureErrorLogItemsForTenant

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAzureErrorLogItemsForTenant` |
| Source | `Cmdlets/GetAzureErrorLogItemsForTenant.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/azure-errors/for-tenant/{TenantPrincipalId}/dx? |
| Return Type | List<[AzureErrorLogItem](../models/AzureErrorLogItem.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/azure-errors/for-tenant/{TenantPrincipalId}/dx?` and deserializes to List<[AzureErrorLogItem](../models/AzureErrorLogItem.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |
| TenantPrincipalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[AzureErrorLogItem](../models/AzureErrorLogItem.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
