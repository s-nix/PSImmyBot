---
title: Get-GlobalSoftware
---

# Get-GlobalSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalSoftware` |
| Source | `Cmdlets/GetGlobalSoftware.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}? |
| Return Type | [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/global/{SoftwareIdentifier}?` and deserializes to [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Include | `String` | False | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
