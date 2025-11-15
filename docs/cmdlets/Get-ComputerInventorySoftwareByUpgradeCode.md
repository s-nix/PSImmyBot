---
title: Get-ComputerInventorySoftwareByUpgradeCode
---

# Get-ComputerInventorySoftwareByUpgradeCode

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerInventorySoftwareByUpgradeCode` |
| Source | `Cmdlets/GetComputerInventorySoftwareByUpgradeCode.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/inventory-software/search-by-upgrade-code? |
| Return Type | List<[ComputerInventorySoftware](../models/ComputerInventorySoftware.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/inventory-software/search-by-upgrade-code?` and deserializes to List<[ComputerInventorySoftware](../models/ComputerInventorySoftware.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| UpgradeCode | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ComputerInventorySoftware](../models/ComputerInventorySoftware.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
