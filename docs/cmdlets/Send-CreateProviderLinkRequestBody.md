---
title: Send-CreateProviderLinkRequestBody
---

# Send-CreateProviderLinkRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateProviderLinkRequestBody` |
| Source | `Cmdlets/SendCreateProviderLinkRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links? |
| Return Type | `CreateProviderLinkRequestBody, GetProviderLinkResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links?` and deserializes to `CreateProviderLinkRequestBody, GetProviderLinkResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateProviderLinkRequestBody` | True | — | All | None |
| ThrowIfAgentInstallerVersionNotSet | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateProviderLinkRequestBody, GetProviderLinkResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
