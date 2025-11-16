---
title: New-ImmyGetProviderLinkResponse
---

# New-ImmyGetProviderLinkResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetProviderLinkResponse` |
| Source | `Cmdlets/NewGetProviderLinkResponse.cs` |
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
| Computers | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| Disabled | `Boolean` | True | — | All | None |
| ErrorMessage | `String` | False | — | All | None |
| ExcludedCapabilities | `ICollection`1` | False | — | All | None |
| GetFormSchemaFailedMessage | `String` | False | — | All | None |
| GetLatestAgentVersionFailedMessage | `String` | False | — | All | None |
| GetProviderFailedMessage | `String` | False | — | All | None |
| HealthStatus | [HealthStatus](../models/HealthStatus.md) | True | — | All | None |
| HealthStatusMessage | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IncludeClientsFailedMessage | `String` | False | — | All | None |
| InputsWithStoredPasswords | `ICollection`1` | False | — | All | None |
| LatestAgentVersion | `String` | False | — | All | None |
| LinkedFromProviders | `ICollection`1` | False | — | All | None |
| Name | `String` | False | — | All | None |
| OwnerTenantId | `Int32` | True | — | All | None |
| ProviderCapabilities | `ICollection`1` | False | — | All | None |
| ProviderClients | `ICollection`1` | False | — | All | None |
| ProviderPluginBaseUrl | `String` | False | — | All | None |
| ProvidersLinkedFromThisProvider | `ICollection`1` | False | — | All | None |
| ProviderTypeFormData | `Object` | True | — | All | None |
| ProviderTypeId | `Guid` | True | — | All | None |
| RunScriptPriority | `Int32` | True | — | All | None |
| Schedules | `ICollection`1` | False | — | All | None |
| SupportedCrossProviderClientLinkages | `ICollection`1` | False | — | All | None |
| SupportedCrossProviderInitializationLinkages | `ICollection`1` | False | — | All | None |
| SupportsDeviceUpdating | `Boolean` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByName | `String` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
