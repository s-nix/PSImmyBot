---
title: Send-BrandingsValidateTimeFormat
---

# Send-BrandingsValidateTimeFormat

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBrandingsValidateTimeFormat` |
| Source | `Cmdlets/SendBrandingsValidateTimeFormat.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/brandings/validate-time-format/{TimeFormat}? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/brandings/validate-time-format/{TimeFormat}?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TimeFormat | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
