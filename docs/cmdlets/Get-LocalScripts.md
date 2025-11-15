---
title: Get-LocalScripts
---

# Get-LocalScripts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalScripts` |
| Source | `Cmdlets/GetLocalScripts.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/local? |
| Return Type | List<[GetLocalScriptResponse](../models/GetLocalScriptResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/local?` and deserializes to List<[GetLocalScriptResponse](../models/GetLocalScriptResponse.md)>.
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

- List<[GetLocalScriptResponse](../models/GetLocalScriptResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
