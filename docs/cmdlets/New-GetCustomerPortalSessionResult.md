---
title: New-GetCustomerPortalSessionResult
---

# New-GetCustomerPortalSessionResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetCustomerPortalSessionResult` |
| Source | `Cmdlets/NewGetCustomerPortalSessionResult.cs` |
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
| AccessUrl | `String` | False | — | All | None |
| CreatedAt | `DateTimeOffset` | True | — | All | None |
| CustomerId | `String` | False | — | All | None |
| ExpiresAt | `Nullable`1` | False | — | All | None |
| PortalSessionId | `String` | False | — | All | None |
| Status | [CustomerPortalSessionStatus](../models/CustomerPortalSessionStatus.md) | True | — | All | None |
| Token | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
