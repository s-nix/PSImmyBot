---
title: New-ImmyGetProviderAgentResponse
---

# New-ImmyGetProviderAgentResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetProviderAgentResponse` |
| Source | `Cmdlets/NewGetProviderAgentResponse.cs` |
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
| AgentVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| DeviceDetails | [DeviceDetails](../models/DeviceDetails.md) | True | — | All | None |
| DeviceUpdateFormData | `Object` | False | — | All | None |
| ExternalAgentId | `String` | False | — | All | None |
| ExternalClientId | `String` | False | — | All | None |
| ExternalClientName | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| InternalData | `Object` | False | — | All | None |
| IsOnline | `Boolean` | True | — | All | None |
| LastUpdatedUtc | `DateTimeOffset` | True | — | All | None |
| OnboardingOptions | [AgentOnboardingOptions](../models/AgentOnboardingOptions.md) | True | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |
| ProviderTypeId | `Guid` | True | — | All | None |
| RequireManualIdentification | `Boolean` | True | — | All | None |
| RunScriptPriority | `Int32` | True | — | All | None |
| SupportsRunningScripts | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
