---
title: Get-ComputerInventory
---

# Get-ComputerInventory

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerInventory` |
| Source | `Cmdlets/GetComputerInventory.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/inventory? |
| Return Type | `List<DxComputerInventoryScriptResult>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/inventory?` and deserializes to `List<DxComputerInventoryScriptResult>`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | `DataSourceLoadOptions` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<DxComputerInventoryScriptResult>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
