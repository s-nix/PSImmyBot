---
title: Get-ComputerInventoryAllSoftware
---

# Get-ComputerInventoryAllSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerInventoryAllSoftware` |
| Source | `Cmdlets/GetComputerInventoryAllSoftware.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/all-inventory-software/search-by-name? |
| Return Type | List<[ComputerInventoryAllSoftware](../models/ComputerInventoryAllSoftware.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/all-inventory-software/search-by-name?` and deserializes to List<[ComputerInventoryAllSoftware](../models/ComputerInventoryAllSoftware.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SearchMode | `Nullable`1` | False | — | All | None |
| SoftwareName | `String` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ComputerInventoryAllSoftware](../models/ComputerInventoryAllSoftware.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
