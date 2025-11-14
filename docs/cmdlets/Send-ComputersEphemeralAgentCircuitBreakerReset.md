---
title: Send-ComputersEphemeralAgentCircuitBreakerReset
---

# Send-ComputersEphemeralAgentCircuitBreakerReset

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendComputersEphemeralAgentCircuitBreakerReset` |
| Source | `Cmdlets/SendComputersEphemeralAgentCircuitBreakerReset.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/{ComputerId}/ephemeral-agent-circuit-breaker/reset? |
| Return Type | [OpResultCircuitBreakerState](../models/OpResultCircuitBreakerState.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/ephemeral-agent-circuit-breaker/reset?` and deserializes to [OpResultCircuitBreakerState](../models/OpResultCircuitBreakerState.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [OpResultCircuitBreakerState](../models/OpResultCircuitBreakerState.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
