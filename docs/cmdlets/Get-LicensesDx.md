---
title: Get-LicensesDx
---

# Get-LicensesDx

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLicensesDx` |
| Source | `Cmdlets/GetLicensesDx.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/licenses/dx? |
| Return Type | [LoadResult](../models/LoadResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/licenses/dx?` and deserializes to [LoadResult](../models/LoadResult.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- [LoadResult](../models/LoadResult.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
