---
title: New-AgentIdentificationFailure
---

# New-AgentIdentificationFailure

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAgentIdentificationFailure` |
| Source | `Cmdlets/NewAgentIdentificationFailure.cs` |
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
| Computer | [Computer](../models/Computer.md) | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| ExistingAgentId | `Nullable`1` | False | — | All | None |
| FeatureUsageExceeded | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| ManualResolutionDecision | [AgentIdentificationManualResolutionDecision](../models/AgentIdentificationManualResolutionDecision.md) | True | — | All | None |
| Message | `String` | False | — | All | None |
| PendingAgent | [ProviderAgent](../models/ProviderAgent.md) | True | — | All | None |
| PendingAgentId | `Int32` | True | — | All | None |
| RequiresManualResolution | `Boolean` | True | — | All | None |
| Resolved | `Boolean` | True | — | All | None |
| UnsupportedDeviceType | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
