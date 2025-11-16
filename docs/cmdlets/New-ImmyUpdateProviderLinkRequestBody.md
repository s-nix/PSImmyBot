---
title: New-ImmyUpdateProviderLinkRequestBody
---

# New-ImmyUpdateProviderLinkRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateProviderLinkRequestBody` |
| Source | `Cmdlets/NewUpdateProviderLinkRequestBody.cs` |
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
| Disabled | `Boolean` | True | — | All | None |
| ExcludedCapabilities | `ICollection`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| ProviderTypeFormData | `Object` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
