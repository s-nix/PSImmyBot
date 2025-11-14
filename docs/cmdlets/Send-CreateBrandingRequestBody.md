---
title: Send-CreateBrandingRequestBody
---

# Send-CreateBrandingRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateBrandingRequestBody` |
| Source | `Cmdlets/SendCreateBrandingRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/brandings? |
| Return Type | `CreateBrandingRequestBody, GetBrandingResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/brandings?` and deserializes to `CreateBrandingRequestBody, GetBrandingResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateBrandingRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateBrandingRequestBody, GetBrandingResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
