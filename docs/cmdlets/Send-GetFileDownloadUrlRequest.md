---
title: Send-GetFileDownloadUrlRequest
---

# Send-GetFileDownloadUrlRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetFileDownloadUrlRequest` |
| Source | `Cmdlets/SendGetFileDownloadUrlRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/media/requestFileDownloadUrl? |
| Return Type | `GetFileDownloadUrlRequest, string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/media/requestFileDownloadUrl?` and deserializes to `GetFileDownloadUrlRequest, string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `GetFileDownloadUrlRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetFileDownloadUrlRequest, string` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
