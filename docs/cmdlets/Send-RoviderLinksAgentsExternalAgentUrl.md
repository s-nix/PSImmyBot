---
title: Send-RoviderLinksAgentsExternalAgentUrl
---

# Send-RoviderLinksAgentsExternalAgentUrl

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderLinksAgentsExternalAgentUrl` |
| Source | `Cmdlets/SendRoviderLinksAgentsExternalAgentUrl.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/{ComputerId}/external-agent-url? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/{ComputerId}/external-agent-url?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
