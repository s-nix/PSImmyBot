---
title: Send-BillingCreateCustomerPortalSession
---

# Send-BillingCreateCustomerPortalSession

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBillingCreateCustomerPortalSession` |
| Source | `Cmdlets/SendBillingCreateCustomerPortalSession.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/billing/create-customer-portal-session? |
| Return Type | [GetCustomerPortalSessionResult](../models/GetCustomerPortalSessionResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/billing/create-customer-portal-session?` and deserializes to [GetCustomerPortalSessionResult](../models/GetCustomerPortalSessionResult.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetCustomerPortalSessionResult](../models/GetCustomerPortalSessionResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
