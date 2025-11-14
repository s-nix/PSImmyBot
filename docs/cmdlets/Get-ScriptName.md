---
title: Get-ScriptName
---

# Get-ScriptName

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetScriptName` |
| Source | `Cmdlets/GetScriptName.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/local/names? |
| Return Type | List<[GetScriptNameResponse](../models/GetScriptNameResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/local/names?` and deserializes to List<[GetScriptNameResponse](../models/GetScriptNameResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptCategory | `Nullable`1` | False | — | All | None |
| SearchFilter | `String` | False | — | All | None |
| SearchType | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetScriptNameResponse](../models/GetScriptNameResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
