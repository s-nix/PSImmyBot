---
title: Get-ImmyLicenses
---

# Get-ImmyLicenses

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLicenses` |
| Source | `Cmdlets/GetLicenses.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/licenses? |
| Return Type | List<[GetLicenseResponse](../models/GetLicenseResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/licenses?` and deserializes to List<[GetLicenseResponse](../models/GetLicenseResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Filters | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetLicenseResponse](../models/GetLicenseResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
