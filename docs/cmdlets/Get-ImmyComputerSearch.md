---
title: Get-ImmyComputerSearch
---

# Get-ImmyComputerSearch

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerSearch` |
| Source | `Cmdlets/GetComputerSearch.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers? |
| Return Type | List<[ComputerSearch](../models/ComputerSearch.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers?` and deserializes to List<[ComputerSearch](../models/ComputerSearch.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Name | `String` | False | — | All | None |
| OrderByUpdatedDate | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ComputerSearch](../models/ComputerSearch.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
