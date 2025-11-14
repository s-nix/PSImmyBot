---
title: Get-OpResultCircuitBreakerState
---

# Get-OpResultCircuitBreakerState

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOpResultCircuitBreakerState` |
| Source | `Cmdlets/GetOpResultCircuitBreakerState.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/ephemeral-agent-circuit-breaker? |
| Return Type | `OpResultCircuitBreakerState` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/ephemeral-agent-circuit-breaker?` and deserializes to `OpResultCircuitBreakerState`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `OpResultCircuitBreakerState` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
