---
title: Push-ImmyUpdateBrandingRequestBody
---

# Push-ImmyUpdateBrandingRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateBrandingRequestBody` |
| Source | `Cmdlets/PushUpdateBrandingRequestBody.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/brandings/{Id}? |
| Return Type | [UpdateBrandingRequestBody](../models/UpdateBrandingRequestBody.md), [GetBrandingResponse](../models/GetBrandingResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/brandings/{Id}?` and deserializes to [UpdateBrandingRequestBody](../models/UpdateBrandingRequestBody.md), [GetBrandingResponse](../models/GetBrandingResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateBrandingRequestBody](../models/UpdateBrandingRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateBrandingRequestBody](../models/UpdateBrandingRequestBody.md), [GetBrandingResponse](../models/GetBrandingResponse.md) records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
