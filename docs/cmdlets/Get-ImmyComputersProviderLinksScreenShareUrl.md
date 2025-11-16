---
title: Get-ImmyComputersProviderLinksScreenShareUrl
---

# Get-ImmyComputersProviderLinksScreenShareUrl

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputersProviderLinksScreenShareUrl` |
| Source | `Cmdlets/GetComputersProviderLinksScreenShareUrl.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/provider-links/{ProviderLinkId}/screen-share-url? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/provider-links/{ProviderLinkId}/screen-share-url?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
