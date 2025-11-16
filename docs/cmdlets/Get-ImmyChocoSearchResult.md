---
title: Get-ImmyChocoSearchResult
---

# Get-ImmyChocoSearchResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetChocoSearchResult` |
| Source | `Cmdlets/GetChocoSearchResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/chocolatey/search? |
| Return Type | List<[ChocoSearchResult](../models/ChocoSearchResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/chocolatey/search?` and deserializes to List<[ChocoSearchResult](../models/ChocoSearchResult.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SearchTerm | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ChocoSearchResult](../models/ChocoSearchResult.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
