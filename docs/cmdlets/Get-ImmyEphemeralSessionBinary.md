---
title: Get-ImmyEphemeralSessionBinary
---

# Get-ImmyEphemeralSessionBinary

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetEphemeralSessionBinary` |
| Source | `Cmdlets/GetEphemeralSessionBinary.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/ephemeral-session/{EphemeralSessionId}/{AgentInstanceId}/{ProviderAgentId}? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/ephemeral-session/{EphemeralSessionId}/{AgentInstanceId}/{ProviderAgentId}?` and deserializes to `byte[]`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AgentInstanceId | `String` | True | — | All | None |
| EphemeralSessionId | `String` | True | — | All | None |
| ProviderAgentId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
