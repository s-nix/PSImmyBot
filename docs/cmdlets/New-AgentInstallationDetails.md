---
title: New-AgentInstallationDetails
---

# New-AgentInstallationDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAgentInstallationDetails` |
| Source | `Cmdlets/NewAgentInstallationDetails.cs` |
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
| DetectedInstalledVersion | `String` | False | — | All | None |
| IsApplicationRegistryEntryPresent | `Boolean` | True | — | All | None |
| IsServicePresent | `Boolean` | True | — | All | None |
| IsServiceRunning | `Boolean` | True | — | All | None |
| RunningBinaryVersion | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
