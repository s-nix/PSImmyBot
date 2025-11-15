---
title: Send-ProviderLinkPluginProxyRequest
---

# Send-ProviderLinkPluginProxyRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendProviderLinkPluginProxyRequest` |
| Source | `Cmdlets/SendProviderLinkPluginProxyRequest.cs` |
| HTTP Method | POST |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| CatchAll | `String` | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
