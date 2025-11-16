---
title: New-ImmyGetEphemeralAgentResponse
---

# New-ImmyGetEphemeralAgentResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetEphemeralAgentResponse` |
| Source | `Cmdlets/NewGetEphemeralAgentResponse.cs` |
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
| CreatedAt | `DateTimeOffset` | True | — | All | None |
| Id | `Guid` | True | — | All | None |
| IsConnected | `Boolean` | True | — | All | None |
| LastActivity | `DateTimeOffset` | True | — | All | None |
| StartupInfo | [AgentStartupInfo](../models/AgentStartupInfo.md) | True | — | All | None |
| TotalProcessedScriptCount | `Int32` | True | — | All | None |
| TotalReceievedBytes | `Int32` | True | — | All | None |
| TotalSentBytes | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
