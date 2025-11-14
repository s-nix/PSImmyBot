---
title: Push-UpdateProviderLinkRequestBody
---

# Push-UpdateProviderLinkRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateProviderLinkRequestBody` |
| Source | `Cmdlets/PushUpdateProviderLinkRequestBody.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/provider-links/{Id}? |
| Return Type | `UpdateProviderLinkRequestBody, GetProviderLinkResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/provider-links/{Id}?` and deserializes to `UpdateProviderLinkRequestBody, GetProviderLinkResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateProviderLinkRequestBody` | True | — | All | None |
| ThrowIfAgentInstallerVersionNotSet | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateProviderLinkRequestBody, GetProviderLinkResponse` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
