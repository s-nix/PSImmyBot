---
title: New-ImmyGetSubscriptionDetailsResponse
---

# New-ImmyGetSubscriptionDetailsResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetSubscriptionDetailsResponse` |
| Source | `Cmdlets/NewGetSubscriptionDetailsResponse.cs` |
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
| FeaturesEnabledFromSubscription | `ICollection`1` | False | — | All | None |
| PlanId | `String` | False | — | All | None |
| Status | [SubscriptionStatus](../models/SubscriptionStatus.md) | True | — | All | None |
| SubscriptionActivatedDateUtc | `Nullable`1` | False | — | All | None |
| TrialEndUtc | `Nullable`1` | False | — | All | None |
| TrialStartUtc | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
