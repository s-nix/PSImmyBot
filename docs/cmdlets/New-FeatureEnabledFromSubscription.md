---
title: New-FeatureEnabledFromSubscription
---

# New-FeatureEnabledFromSubscription

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewFeatureEnabledFromSubscription` |
| Source | `Cmdlets/NewFeatureEnabledFromSubscription.cs` |
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
| FeatureCustomValue | `String` | False | — | All | None |
| FeatureEntitlementType | `FeatureEntitlementType` | True | — | All | None |
| FeatureId | `String` | False | — | All | None |
| FeatureUsage | `FeatureUsageDetails` | True | — | All | None |
| IsUsageBased | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
