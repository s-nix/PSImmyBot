---
title: Get-ImmyLocalSoftwareList
---

# Get-ImmyLocalSoftwareList

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalSoftwareList` |
| Source | `Cmdlets/GetLocalSoftwareList.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/local? |
| Return Type | List<[GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/local?` and deserializes to List<[GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Include | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
