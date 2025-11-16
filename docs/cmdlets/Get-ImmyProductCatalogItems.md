---
title: Get-ImmyProductCatalogItems
---

# Get-ImmyProductCatalogItems

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetProductCatalogItems` |
| Source | `Cmdlets/GetProductCatalogItems.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/billing/product-catalog-items? |
| Return Type | [GetProductCatalogItemsResponse](../models/GetProductCatalogItemsResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/billing/product-catalog-items?` and deserializes to [GetProductCatalogItemsResponse](../models/GetProductCatalogItemsResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetProductCatalogItemsResponse](../models/GetProductCatalogItemsResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
