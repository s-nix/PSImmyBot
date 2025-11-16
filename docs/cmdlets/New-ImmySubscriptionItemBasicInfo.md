---
title: New-ImmySubscriptionItemBasicInfo
---

# New-ImmySubscriptionItemBasicInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSubscriptionItemBasicInfo` |
| Source | `Cmdlets/NewSubscriptionItemBasicInfo.cs` |
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
| ItemDescription | `String` | False | — | All | None |
| ItemId | `String` | False | — | All | None |
| ItemName | `String` | False | — | All | None |
| ItemType | [SubscriptionItemType](../models/SubscriptionItemType.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
