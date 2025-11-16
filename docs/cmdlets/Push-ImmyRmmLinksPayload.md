---
title: Push-ImmyRmmLinksPayload
---

# Push-ImmyRmmLinksPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushRmmLinksPayload` |
| Source | `Cmdlets/PushRmmLinksPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/rmm-links/{Id}? |
| Return Type | [UpdateProviderLinkRequestBody](../models/UpdateProviderLinkRequestBody.md), [GetProviderLinkResponse](../models/GetProviderLinkResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/rmm-links/{Id}?` and deserializes to [UpdateProviderLinkRequestBody](../models/UpdateProviderLinkRequestBody.md), [GetProviderLinkResponse](../models/GetProviderLinkResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateProviderLinkRequestBody](../models/UpdateProviderLinkRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateProviderLinkRequestBody](../models/UpdateProviderLinkRequestBody.md), [GetProviderLinkResponse](../models/GetProviderLinkResponse.md) records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
