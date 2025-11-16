---
title: Send-ImmyCreateLicenseRequestBody
---

# Send-ImmyCreateLicenseRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLicenseRequestBody` |
| Source | `Cmdlets/SendCreateLicenseRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/licenses? |
| Return Type | [CreateLicenseRequestBody](../models/CreateLicenseRequestBody.md), [GetLicenseResponse](../models/GetLicenseResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/licenses?` and deserializes to [CreateLicenseRequestBody](../models/CreateLicenseRequestBody.md), [GetLicenseResponse](../models/GetLicenseResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateLicenseRequestBody](../models/CreateLicenseRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateLicenseRequestBody](../models/CreateLicenseRequestBody.md), [GetLicenseResponse](../models/GetLicenseResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
