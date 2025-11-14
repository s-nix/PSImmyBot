---
title: New-GetAgentIdentificationFailureResponse
---

# New-GetAgentIdentificationFailureResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetAgentIdentificationFailureResponse` |
| Source | `Cmdlets/NewGetAgentIdentificationFailureResponse.cs` |
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
| ComputerId | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| ExistingAgent | [IProviderAgentDetails](../models/IProviderAgentDetails.md) | True | — | All | None |
| ExistingAgentId | `Nullable`1` | False | — | All | None |
| ExistingComputerName | `String` | False | — | All | None |
| ExistingManufacturer | `String` | False | — | All | None |
| ExistingOperatingSystem | `String` | False | — | All | None |
| ExistingOsInstallDate | `Nullable`1` | False | — | All | None |
| ExistingPrimaryUserFirstName | `String` | False | — | All | None |
| ExistingPrimaryUserLastName | `String` | False | — | All | None |
| ExistingSerialNumber | `String` | False | — | All | None |
| ExistingTenantName | `String` | False | — | All | None |
| FeatureUsageExceeded | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| ManualResolutionDecision | [AgentIdentificationManualResolutionDecision](../models/AgentIdentificationManualResolutionDecision.md) | True | — | All | None |
| Message | `String` | False | — | All | None |
| PendingAgentId | `Nullable`1` | False | — | All | None |
| RequiresManualResolution | `Boolean` | True | — | All | None |
| Resolved | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
