---
title: Send-ImmySubscriptionDetails
---

# Send-ImmySubscriptionDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSubscriptionDetails` |
| Source | `Cmdlets/SendSubscriptionDetails.cs` |
| HTTP Method | POST |
| Endpoint | /api/v2/manager/update-subscription? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v2/manager/update-subscription?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [SubscriptionDetails](../models/SubscriptionDetails.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
