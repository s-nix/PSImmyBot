---
title: Get-ImmyComputerInventory
---

# Get-ImmyComputerInventory

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerInventory` |
| Source | `Cmdlets/GetComputerInventory.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/inventory? |
| Return Type | List<[DxComputerInventoryScriptResult](../models/DxComputerInventoryScriptResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/inventory?` and deserializes to List<[DxComputerInventoryScriptResult](../models/DxComputerInventoryScriptResult.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[DxComputerInventoryScriptResult](../models/DxComputerInventoryScriptResult.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
