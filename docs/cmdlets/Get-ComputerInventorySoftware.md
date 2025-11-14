---
title: Get-ComputerInventorySoftware
---

# Get-ComputerInventorySoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerInventorySoftware` |
| Source | `Cmdlets/GetComputerInventorySoftware.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/inventory-software/search-by-name? |
| Return Type | `List<ComputerInventorySoftware>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/inventory-software/search-by-name?` and deserializes to `List<ComputerInventorySoftware>`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SearchMode | `Nullable`1` | False | — | All | None |
| SoftwareName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<ComputerInventorySoftware>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
