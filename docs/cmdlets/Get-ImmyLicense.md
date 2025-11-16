---
title: Get-ImmyLicense
---

# Get-ImmyLicense

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLicense` |
| Source | `Cmdlets/GetLicense.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/licenses/{LicenseId}? |
| Return Type | [GetLicenseResponse](../models/GetLicenseResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/licenses/{LicenseId}?` and deserializes to [GetLicenseResponse](../models/GetLicenseResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LicenseId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetLicenseResponse](../models/GetLicenseResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
