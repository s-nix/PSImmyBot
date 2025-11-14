---
title: Get-BillingPlatformDetails
---

# Get-BillingPlatformDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetBillingPlatformDetails` |
| Source | `Cmdlets/GetBillingPlatformDetails.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/billing/billing-platform-details? |
| Return Type | [BillingPlatformDetails](../models/BillingPlatformDetails.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/billing/billing-platform-details?` and deserializes to [BillingPlatformDetails](../models/BillingPlatformDetails.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [BillingPlatformDetails](../models/BillingPlatformDetails.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
