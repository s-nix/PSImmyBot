---
title: Get-CircuitBreakerState
---

# Get-CircuitBreakerState

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetCircuitBreakerState` |
| Source | `Cmdlets/GetCircuitBreakerState.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/metrics/circuit-breakers? |
| Return Type | `List<CircuitBreakerState>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/metrics/circuit-breakers?` and deserializes to `List<CircuitBreakerState>`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `List<CircuitBreakerState>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
