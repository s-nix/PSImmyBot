---
title: New-ImmySubscriptionFeature
---

# New-ImmySubscriptionFeature

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSubscriptionFeature` |
| Source | `Cmdlets/NewSubscriptionFeature.cs` |
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
| ExpiresAtUtc | `Nullable`1` | False | — | All | None |
| FeatureId | `String` | False | — | All | None |
| IsEnabled | `Boolean` | True | — | All | None |
| IsUnlimited | `Boolean` | True | — | All | None |
| Value | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
