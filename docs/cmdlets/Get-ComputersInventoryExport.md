---
title: Get-ComputersInventoryExport
---

# Get-ComputersInventoryExport

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputersInventoryExport` |
| Source | `Cmdlets/GetComputersInventoryExport.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/inventory/export? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/inventory/export?` and deserializes to `byte[]`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |
| OutFile | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
