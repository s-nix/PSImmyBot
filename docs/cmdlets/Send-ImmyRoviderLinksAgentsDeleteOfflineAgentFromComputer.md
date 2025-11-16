---
title: Send-ImmyRoviderLinksAgentsDeleteOfflineAgentFromComputer
---

# Send-ImmyRoviderLinksAgentsDeleteOfflineAgentFromComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderLinksAgentsDeleteOfflineAgentFromComputer` |
| Source | `Cmdlets/SendRoviderLinksAgentsDeleteOfflineAgentFromComputer.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/{AgentId}/delete-offline-agent-from-computer? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/{AgentId}/delete-offline-agent-from-computer?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AgentId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
