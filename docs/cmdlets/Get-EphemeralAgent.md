---
title: Get-EphemeralAgent
---

# Get-EphemeralAgent

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetEphemeralAgent` |
| Source | `Cmdlets/GetEphemeralAgent.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/ephemeral-agent? |
| Return Type | `GetEphemeralAgentResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/ephemeral-agent?` and deserializes to `GetEphemeralAgentResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetEphemeralAgentResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
