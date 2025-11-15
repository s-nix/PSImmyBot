---
title: Get-RmmLinks
---

# Get-RmmLinks

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetRmmLinks` |
| Source | `Cmdlets/GetRmmLinks.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/rmm-links? |
| Return Type | List<[GetProviderLinkResponse](../models/GetProviderLinkResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/rmm-links?` and deserializes to List<[GetProviderLinkResponse](../models/GetProviderLinkResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IncludeClients | `Nullable`1` | False | — | All | None |
| IncludeUnlinkedClients | `Nullable`1` | False | — | All | None |
| ThrowIfAgentInstallerVersionNotSet | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetProviderLinkResponse](../models/GetProviderLinkResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
