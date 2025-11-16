---
title: New-ImmyAzureTenantLinkResponse
---

# New-ImmyAzureTenantLinkResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureTenantLinkResponse` |
| Source | `Cmdlets/NewAzureTenantLinkResponse.cs` |
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
| AzTenantId | `String` | False | — | All | None |
| AzureTenant | [AzureTenantResponse](../models/AzureTenantResponse.md) | True | — | All | None |
| ImmyTenantId | `Int32` | True | — | All | None |
| LimitToDomains | `ICollection`1` | False | — | All | None |
| ShouldLimitDomains | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
