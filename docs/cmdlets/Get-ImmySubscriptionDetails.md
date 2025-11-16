---
title: Get-ImmySubscriptionDetails
---

# Get-ImmySubscriptionDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSubscriptionDetails` |
| Source | `Cmdlets/GetSubscriptionDetails.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/billing/subscription-details? |
| Return Type | [GetSubscriptionDetailsResponse](../models/GetSubscriptionDetailsResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/billing/subscription-details?` and deserializes to [GetSubscriptionDetailsResponse](../models/GetSubscriptionDetailsResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetSubscriptionDetailsResponse](../models/GetSubscriptionDetailsResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
