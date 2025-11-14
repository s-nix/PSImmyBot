---
title: Get-ProviderLink
---

# Get-ProviderLink

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetProviderLink` |
| Source | `Cmdlets/GetProviderLink.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-links/{Id}? |
| Return Type | `GetProviderLinkResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-links/{Id}?` and deserializes to `GetProviderLinkResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| IncludeClients | `Nullable`1` | False | — | All | None |
| IncludeProvidersLinkedFromThisProvider | `Nullable`1` | False | — | All | None |
| ThrowIfAgentInstallerVersionNotSet | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetProviderLinkResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
