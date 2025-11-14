---
title: New-LinkedExternalLink
---

# New-LinkedExternalLink

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewLinkedExternalLink` |
| Source | `Cmdlets/NewLinkedExternalLink.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IsExternalClientLinkingEnabled | `Boolean` | True | — | All | None |
| IsExternalProviderInitializedFromThisProvider | `Boolean` | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |
| ProviderLinkName | `String` | False | — | All | None |
| ProviderTypeId | `Guid` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
