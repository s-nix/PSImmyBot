---
title: Get-ImmyComputersInventoryScriptResults
---

# Get-ImmyComputersInventoryScriptResults

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputersInventoryScriptResults` |
| Source | `Cmdlets/GetComputersInventoryScriptResults.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/inventory-script-results/{InventoryKey}? |
| Return Type | `JsonDocument` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/inventory-script-results/{InventoryKey}?` and deserializes to `JsonDocument`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| InventoryKey | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `JsonDocument` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
