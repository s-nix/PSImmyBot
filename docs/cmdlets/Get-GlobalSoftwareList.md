---
title: Get-GlobalSoftwareList
---

# Get-GlobalSoftwareList

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalSoftwareList` |
| Source | `Cmdlets/GetGlobalSoftwareList.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/global? |
| Return Type | List<[GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/global?` and deserializes to List<[GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Include | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
