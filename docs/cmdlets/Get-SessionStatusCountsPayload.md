---
title: Get-SessionStatusCountsPayload
---

# Get-SessionStatusCountsPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSessionStatusCountsPayload` |
| Source | `Cmdlets/GetSessionStatusCountsPayload.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-sessions/status-counts? |
| Return Type | `SessionStatusCountsPayload` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-sessions/status-counts?` and deserializes to `SessionStatusCountsPayload`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `SessionStatusCountsPayload` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
