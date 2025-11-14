---
title: Get-License
---

# Get-License

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLicense` |
| Source | `Cmdlets/GetLicense.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/licenses/{LicenseId}? |
| Return Type | `GetLicenseResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/licenses/{LicenseId}?` and deserializes to `GetLicenseResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LicenseId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetLicenseResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
