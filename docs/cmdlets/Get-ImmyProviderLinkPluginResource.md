---
title: Get-ImmyProviderLinkPluginResource
---

# Get-ImmyProviderLinkPluginResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetProviderLinkPluginResource` |
| Source | `Cmdlets/GetProviderLinkPluginResource.cs` |
| HTTP Method | GET |
| Endpoint | Not applicable |
| Return Type | `object` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` and deserializes to `object`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| CatchAll | `String` | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `object` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
