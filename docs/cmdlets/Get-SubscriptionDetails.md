---
title: Get-SubscriptionDetails
---

# Get-SubscriptionDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSubscriptionDetails` |
| Source | `Cmdlets/GetSubscriptionDetails.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/billing/subscription-details? |
| Return Type | `GetSubscriptionDetailsResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/billing/subscription-details?` and deserializes to `GetSubscriptionDetailsResponse`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `GetSubscriptionDetailsResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
