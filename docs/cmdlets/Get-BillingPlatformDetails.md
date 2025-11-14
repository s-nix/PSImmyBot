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
| Return Type | `BillingPlatformDetails` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/billing/billing-platform-details?` and deserializes to `BillingPlatformDetails`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `BillingPlatformDetails` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
