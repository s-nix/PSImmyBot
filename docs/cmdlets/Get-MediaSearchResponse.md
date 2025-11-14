---
title: Get-MediaSearchResponse
---

# Get-MediaSearchResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMediaSearchResponse` |
| Source | `Cmdlets/GetMediaSearchResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/media/search? |
| Return Type | `MediaSearchResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/media/search?` and deserializes to `MediaSearchResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Filters | `String` | False | — | All | None |
| GlobalOnly | `Nullable`1` | False | — | All | None |
| Page | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| Sorts | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `MediaSearchResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
