---
title: New-IProviderAgentDetails
---

# New-IProviderAgentDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewIProviderAgentDetails` |
| Source | `Cmdlets/NewIProviderAgentDetails.cs` |
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
| DeviceDetails | [DeviceDetails](../models/DeviceDetails.md) | True | — | All | None |
| ExternalAgentId | `String` | False | — | All | None |
| ExternalClientId | `String` | False | — | All | None |
| InternalData | `Object` | False | — | All | None |
| IsOnline | `Boolean` | True | — | All | None |
| LastUpdatedUtc | `DateTimeOffset` | True | — | All | None |
| OnboardingOptions | [AgentOnboardingOptions](../models/AgentOnboardingOptions.md) | True | — | All | None |
| RequireManualIdentification | `Boolean` | True | — | All | None |
| SupportsRunningScripts | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
