---
title: Get-LicensesRequestDownload
---

# Get-LicensesRequestDownload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLicensesRequestDownload` |
| Source | `Cmdlets/GetLicensesRequestDownload.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/licenses/{LicenseId}/request-download? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/licenses/{LicenseId}/request-download?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LicenseId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
