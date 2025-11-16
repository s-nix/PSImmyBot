---
title: Get-ImmyTagList
---

# Get-ImmyTagList

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTagList` |
| Source | `Cmdlets/GetTagList.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tags? |
| Return Type | List<[Tag](../models/Tag.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tags?` and deserializes to List<[Tag](../models/Tag.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Name | `String` | False | — | All | None |
| OrderByUpdatedDate | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[Tag](../models/Tag.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
