---
title: New-ImmySubscriptionDetails
---

# New-ImmySubscriptionDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSubscriptionDetails` |
| Source | `Cmdlets/NewSubscriptionDetails.cs` |
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
| ActivatedAtUtc | `Nullable`1` | False | — | All | None |
| Addons | `ICollection`1` | False | — | All | None |
| CustomerEmail | `String` | False | — | All | None |
| CustomerId | `String` | False | — | All | None |
| Features | `ICollection`1` | False | — | All | None |
| PlanId | `String` | False | — | All | None |
| PlanPrice | `Int32` | True | — | All | None |
| PlanQuantity | `Int32` | True | — | All | None |
| Status | [SubscriptionStatus](../models/SubscriptionStatus.md) | True | — | All | None |
| TrialEndUtc | `Nullable`1` | False | — | All | None |
| TrialStartUtc | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
