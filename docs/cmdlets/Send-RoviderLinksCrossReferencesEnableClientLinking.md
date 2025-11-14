---
title: Send-RoviderLinksCrossReferencesEnableClientLinking
---

# Send-RoviderLinksCrossReferencesEnableClientLinking

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderLinksCrossReferencesEnableClientLinking` |
| Source | `Cmdlets/SendRoviderLinksCrossReferencesEnableClientLinking.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/enable-client-linking? |
| Return Type | [LinkedExternalLink](../models/LinkedExternalLink.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/enable-client-linking?` and deserializes to [LinkedExternalLink](../models/LinkedExternalLink.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ExternalLinkId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [LinkedExternalLink](../models/LinkedExternalLink.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
