---
title: Get-ComputersExport
---

# Get-ComputersExport

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputersExport` |
| Source | `Cmdlets/GetComputersExport.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/export? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/export?` and deserializes to `byte[]`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | `DataSourceLoadOptions` | False | — | All | None |
| OutFile | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
