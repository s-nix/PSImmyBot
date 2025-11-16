---
title: Send-ImmyMetricsCircuitBreakersReset
---

# Send-ImmyMetricsCircuitBreakersReset

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMetricsCircuitBreakersReset` |
| Source | `Cmdlets/SendMetricsCircuitBreakersReset.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/metrics/circuit-breakers/reset? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/metrics/circuit-breakers/reset?`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PolicyName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
