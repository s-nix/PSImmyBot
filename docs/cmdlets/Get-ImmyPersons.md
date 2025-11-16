---
title: Get-ImmyPersons
---

# Get-ImmyPersons

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetPersons` |
| Source | `Cmdlets/GetPersons.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/persons? |
| Return Type | List<[GetSimplePersonResponse](../models/GetSimplePersonResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/persons?` and deserializes to List<[GetSimplePersonResponse](../models/GetSimplePersonResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Filters | `String` | False | — | All | None |
| Page | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| Sorts | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetSimplePersonResponse](../models/GetSimplePersonResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
