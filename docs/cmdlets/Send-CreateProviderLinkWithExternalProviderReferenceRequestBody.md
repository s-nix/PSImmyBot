---
title: Send-CreateProviderLinkWithExternalProviderReferenceRequestBody
---

# Send-CreateProviderLinkWithExternalProviderReferenceRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateProviderLinkWithExternalProviderReferenceRequestBody` |
| Source | `Cmdlets/SendCreateProviderLinkWithExternalProviderReferenceRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/create-with-external-provider-reference? |
| Return Type | [CreateProviderLinkWithExternalProviderReferenceRequestBody](../models/CreateProviderLinkWithExternalProviderReferenceRequestBody.md), [GetProviderLinkResponse](../models/GetProviderLinkResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/create-with-external-provider-reference?` and deserializes to [CreateProviderLinkWithExternalProviderReferenceRequestBody](../models/CreateProviderLinkWithExternalProviderReferenceRequestBody.md), [GetProviderLinkResponse](../models/GetProviderLinkResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateProviderLinkWithExternalProviderReferenceRequestBody](../models/CreateProviderLinkWithExternalProviderReferenceRequestBody.md) | True | — | All | None |
| ThrowIfAgentInstallerVersionNotSet | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateProviderLinkWithExternalProviderReferenceRequestBody](../models/CreateProviderLinkWithExternalProviderReferenceRequestBody.md), [GetProviderLinkResponse](../models/GetProviderLinkResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
