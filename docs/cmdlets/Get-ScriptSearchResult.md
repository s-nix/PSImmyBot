---
title: Get-ScriptSearchResult
---

# Get-ScriptSearchResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetScriptSearchResult` |
| Source | `Cmdlets/GetScriptSearchResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/search? |
| Return Type | List<[ScriptSearchResult](../models/ScriptSearchResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/search?` and deserializes to List<[ScriptSearchResult](../models/ScriptSearchResult.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Filters | `String` | False | — | All | None |
| GlobalOnly | `Nullable`1` | False | — | All | None |
| LocalOnly | `Nullable`1` | False | — | All | None |
| Page | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| Sorts | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ScriptSearchResult](../models/ScriptSearchResult.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
