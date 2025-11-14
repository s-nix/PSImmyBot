---
title: Get-LocalSoftware
---

# Get-LocalSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalSoftware` |
| Source | `Cmdlets/GetLocalSoftware.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}? |
| Return Type | [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/local/{SoftwareIdentifier}?` and deserializes to [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Include | `String` | False | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
