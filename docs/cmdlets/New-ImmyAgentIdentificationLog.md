---
title: New-ImmyAgentIdentificationLog
---

# New-ImmyAgentIdentificationLog

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAgentIdentificationLog` |
| Source | `Cmdlets/NewAgentIdentificationLog.cs` |
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
| Id | `Int32` | True | — | All | None |
| LogType | [AgentIdentificationLogType](../models/AgentIdentificationLogType.md) | True | — | All | None |
| Message | `String` | False | — | All | None |
| ProviderAgent | [ProviderAgent](../models/ProviderAgent.md) | True | — | All | None |
| ProviderAgentId | `Int32` | True | — | All | None |
| TimeUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
