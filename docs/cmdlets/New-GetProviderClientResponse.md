---
title: New-GetProviderClientResponse
---

# New-GetProviderClientResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetProviderClientResponse` |
| Source | `Cmdlets/NewGetProviderClientResponse.cs` |
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
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| ExternalClientId | `String` | False | — | All | None |
| ExternalClientName | `String` | False | — | All | None |
| InternalData | `Object` | False | — | All | None |
| LinkedToTenantId | `Nullable`1` | False | — | All | None |
| ProviderLink | [GetProviderLinkResponse](../models/GetProviderLinkResponse.md) | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |
| Status | `String` | False | — | All | None |
| Types | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
