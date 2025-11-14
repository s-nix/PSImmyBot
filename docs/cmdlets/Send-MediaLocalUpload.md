---
title: Send-MediaLocalUpload
---

# Send-MediaLocalUpload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMediaLocalUpload` |
| Source | `Cmdlets/SendMediaLocalUpload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/media/local/upload? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/media/local/upload?`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
