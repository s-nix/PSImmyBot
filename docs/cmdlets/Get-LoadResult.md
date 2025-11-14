---
title: Get-LoadResult
---

# Get-LoadResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLoadResult` |
| Source | `Cmdlets/GetLoadResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/dx? |
| Return Type | [LoadResult](../models/LoadResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/dx?` and deserializes to [LoadResult](../models/LoadResult.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| DatabaseType | `Nullable`1` | False | — | All | None |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- [LoadResult](../models/LoadResult.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
