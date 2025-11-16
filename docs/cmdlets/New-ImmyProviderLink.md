---
title: New-ImmyProviderLink
---

# New-ImmyProviderLink

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewProviderLink` |
| Source | `Cmdlets/NewProviderLink.cs` |
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
| Agents | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Disabled | `Boolean` | True | — | All | None |
| DisabledOrUnhealthy | `Boolean` | True | — | All | None |
| ExcludedCapabilities | `ICollection`1` | False | — | All | None |
| HealthStatus | [HealthStatus](../models/HealthStatus.md) | True | — | All | None |
| HealthStatusMessage | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| LinkedFromProviders | `ICollection`1` | False | — | All | None |
| Name | `String` | False | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| ProviderClients | `ICollection`1` | False | — | All | None |
| ProviderInternalData | [ProviderLinkInternalData](../models/ProviderLinkInternalData.md) | True | — | All | None |
| ProvidersLinkedFromThisProvider | `ICollection`1` | False | — | All | None |
| ProviderTypeFormData | `Object` | True | — | All | None |
| ProviderTypeId | `Guid` | True | — | All | None |
| RunScriptPriority | `Int32` | True | — | All | None |
| Schedules | `ICollection`1` | False | — | All | None |
| TargetAssignments | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UnhealthyCount | `Int32` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
