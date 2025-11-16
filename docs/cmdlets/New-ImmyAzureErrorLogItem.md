---
title: New-ImmyAzureErrorLogItem
---

# New-ImmyAzureErrorLogItem

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureErrorLogItem` |
| Source | `Cmdlets/NewAzureErrorLogItem.cs` |
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
| AzureError | [AzureError](../models/AzureError.md) | True | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Guid` | True | — | All | None |
| Oauth2AccessTokenId | `Nullable`1` | False | — | All | None |
| SourceMessage | `String` | False | — | All | None |
| TenantPrincipalId | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
