---
title: New-ImmySubscriptionFeatureBasicInfo
---

# New-ImmySubscriptionFeatureBasicInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSubscriptionFeatureBasicInfo` |
| Source | `Cmdlets/NewSubscriptionFeatureBasicInfo.cs` |
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
| FeatureDescription | `String` | False | — | All | None |
| FeatureId | `String` | False | — | All | None |
| FeatureName | `String` | False | — | All | None |
| Levels | `ICollection`1` | True | — | All | None |
| Status | [SubscriptionFeatureStatus](../models/SubscriptionFeatureStatus.md) | True | — | All | None |
| Type | [SubscriptionFeatureType](../models/SubscriptionFeatureType.md) | True | — | All | None |
| Unit | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
