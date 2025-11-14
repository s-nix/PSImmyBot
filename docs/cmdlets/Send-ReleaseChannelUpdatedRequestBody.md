---
title: Send-ReleaseChannelUpdatedRequestBody
---

# Send-ReleaseChannelUpdatedRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendReleaseChannelUpdatedRequestBody` |
| Source | `Cmdlets/SendReleaseChannelUpdatedRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/manager/release-channel-updated? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/manager/release-channel-updated?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `ReleaseChannelUpdatedRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
