---
title: Send-ImmyRoviderAgentsResolveFailure
---

# Send-ImmyRoviderAgentsResolveFailure

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderAgentsResolveFailure` |
| Source | `Cmdlets/SendRoviderAgentsResolveFailure.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-agents/resolve-failure/{FailureId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-agents/resolve-failure/{FailureId}?`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| FailureId | `Int32` | True | — | All | None |
| ManualResolutionDecision | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
