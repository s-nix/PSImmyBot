---
title: Remove-ImmyProviderLinksCrossReferences
---

# Remove-ImmyProviderLinksCrossReferences

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveProviderLinksCrossReferences` |
| Source | `Cmdlets/RemoveProviderLinksCrossReferences.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/delete? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/delete?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ExternalLinkId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
