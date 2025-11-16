---
title: New-ImmyProviderClient
---

# New-ImmyProviderClient

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewProviderClient` |
| Source | `Cmdlets/NewProviderClient.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| ExternalClientId | `String` | False | — | All | None |
| ExternalClientName | `String` | False | — | All | None |
| HasCompletedInitialAgentSync | `Boolean` | True | — | All | None |
| InternalData | `Object` | False | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| ProviderAgents | `ICollection`1` | False | — | All | None |
| ProviderLink | [ProviderLink](../models/ProviderLink.md) | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |
| Status | `String` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| Types | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
