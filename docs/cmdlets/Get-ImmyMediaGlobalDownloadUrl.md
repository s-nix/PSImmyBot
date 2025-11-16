---
title: Get-ImmyMediaGlobalDownloadUrl
---

# Get-ImmyMediaGlobalDownloadUrl

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMediaGlobalDownloadUrl` |
| Source | `Cmdlets/GetMediaGlobalDownloadUrl.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/media/global/{Id}/download-url? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/media/global/{Id}/download-url?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
