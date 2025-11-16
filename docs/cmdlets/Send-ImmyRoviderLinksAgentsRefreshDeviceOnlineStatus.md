---
title: Send-ImmyRoviderLinksAgentsRefreshDeviceOnlineStatus
---

# Send-ImmyRoviderLinksAgentsRefreshDeviceOnlineStatus

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderLinksAgentsRefreshDeviceOnlineStatus` |
| Source | `Cmdlets/SendRoviderLinksAgentsRefreshDeviceOnlineStatus.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/{AgentId}/refresh-device-online-status? |
| Return Type | `bool` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/{AgentId}/refresh-device-online-status?` and deserializes to `bool`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AgentId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `bool` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
