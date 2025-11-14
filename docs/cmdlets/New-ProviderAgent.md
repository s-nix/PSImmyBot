---
title: New-ProviderAgent
---

# New-ProviderAgent

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewProviderAgent` |
| Source | `Cmdlets/NewProviderAgent.cs` |
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
| AgentVersion | `SemanticVersion` | True | — | All | None |
| Computer | `Computer` | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| DateAddedUtc | `DateTimeOffset` | True | — | All | None |
| DeletedAt | `Nullable`1` | False | — | All | None |
| DeletedReason | `String` | False | — | All | None |
| DeviceDetails | `DeviceDetails` | True | — | All | None |
| ExternalAgentId | `String` | False | — | All | None |
| ExternalClientId | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IdentificationFailures | `ICollection`1` | False | — | All | None |
| IdentificationLogs | `ICollection`1` | False | — | All | None |
| InternalData | `Object` | False | — | All | None |
| IsMemberOfInitialDeviceSync | `Boolean` | True | — | All | None |
| IsOnline | `Boolean` | True | — | All | None |
| LastUpdatedUtc | `DateTimeOffset` | True | — | All | None |
| OnboardingOptions | `AgentOnboardingOptions` | True | — | All | None |
| ProviderClient | `ProviderClient` | True | — | All | None |
| ProviderLink | `ProviderLink` | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |
| RequireManualIdentification | `Boolean` | True | — | All | None |
| SupportsOnlineStatus | `Boolean` | True | — | All | None |
| SupportsRunningScripts | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
