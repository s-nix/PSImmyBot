---
title: Get-FailedPendingAgent
---

# Get-FailedPendingAgent

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetFailedPendingAgent` |
| Source | `Cmdlets/GetFailedPendingAgent.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-agents/{ComputerId}/pending-conflicts? |
| Return Type | `List<GetFailedPendingAgentResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-agents/{ComputerId}/pending-conflicts?` and deserializes to `List<GetFailedPendingAgentResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<GetFailedPendingAgentResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
