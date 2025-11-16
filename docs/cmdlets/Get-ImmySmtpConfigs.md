---
title: Get-ImmySmtpConfigs
---

# Get-ImmySmtpConfigs

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSmtpConfigs` |
| Source | `Cmdlets/GetSmtpConfigs.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/smtp-configs? |
| Return Type | List<[GetSmtpConfigResponse](../models/GetSmtpConfigResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/smtp-configs?` and deserializes to List<[GetSmtpConfigResponse](../models/GetSmtpConfigResponse.md)>.
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

- List<[GetSmtpConfigResponse](../models/GetSmtpConfigResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
