---
title: Send-UpdateReleaseChannelRequest
---

# Send-UpdateReleaseChannelRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateReleaseChannelRequest` |
| Source | `Cmdlets/SendUpdateReleaseChannelRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/system/update-release-channel? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/system/update-release-channel?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateReleaseChannelRequest](../models/UpdateReleaseChannelRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
