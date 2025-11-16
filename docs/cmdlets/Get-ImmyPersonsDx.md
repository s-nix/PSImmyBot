---
title: Get-ImmyPersonsDx
---

# Get-ImmyPersonsDx

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetPersonsDx` |
| Source | `Cmdlets/GetPersonsDx.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/persons/dx? |
| Return Type | List<[GetSimplePersonResponse](../models/GetSimplePersonResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/persons/dx?` and deserializes to List<[GetSimplePersonResponse](../models/GetSimplePersonResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IncludeTenant | `Nullable`1` | False | — | All | None |
| IncludeUserData | `Nullable`1` | False | — | All | None |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |
| PersonType | `Nullable`1` | False | — | All | None |
| TagId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetSimplePersonResponse](../models/GetSimplePersonResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
