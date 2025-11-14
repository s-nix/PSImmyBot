---
title: New-ProviderLinkCrossReference
---

# New-ProviderLinkCrossReference

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewProviderLinkCrossReference` |
| Source | `Cmdlets/NewProviderLinkCrossReference.cs` |
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
| IsProviderLink2InitializedFromProviderLink1 | `Boolean` | True | — | All | None |
| ProviderLink1 | `ProviderLink` | True | — | All | None |
| ProviderLink1Id | `Int32` | True | — | All | None |
| ProviderLink2 | `ProviderLink` | True | — | All | None |
| ProviderLink2Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
