---
title: Get-AzureErrorLogItems
---

# Get-AzureErrorLogItems

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAzureErrorLogItems` |
| Source | `Cmdlets/GetAzureErrorLogItems.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/azure-errors/dx? |
| Return Type | `List<AzureErrorLogItem>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/azure-errors/dx?` and deserializes to `List<AzureErrorLogItem>`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | `DataSourceLoadOptions` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<AzureErrorLogItem>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
