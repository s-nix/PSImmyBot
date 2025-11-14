---
title: Send-CreateLicenseRequestBody
---

# Send-CreateLicenseRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLicenseRequestBody` |
| Source | `Cmdlets/SendCreateLicenseRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/licenses? |
| Return Type | `CreateLicenseRequestBody, GetLicenseResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/licenses?` and deserializes to `CreateLicenseRequestBody, GetLicenseResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateLicenseRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateLicenseRequestBody, GetLicenseResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
