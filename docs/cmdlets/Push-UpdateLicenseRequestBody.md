---
title: Push-UpdateLicenseRequestBody
---

# Push-UpdateLicenseRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateLicenseRequestBody` |
| Source | `Cmdlets/PushUpdateLicenseRequestBody.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/licenses/{LicenseId}? |
| Return Type | `UpdateLicenseRequestBody, GetLicenseResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/licenses/{LicenseId}?` and deserializes to `UpdateLicenseRequestBody, GetLicenseResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LicenseId | `Int32` | True | — | All | None |
| PayloadBody | `UpdateLicenseRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateLicenseRequestBody, GetLicenseResponse` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
