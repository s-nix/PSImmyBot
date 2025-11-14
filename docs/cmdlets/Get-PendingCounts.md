---
title: Get-PendingCounts
---

# Get-PendingCounts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetPendingCounts` |
| Source | `Cmdlets/GetPendingCounts.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-agents/pending-counts? |
| Return Type | `GetPendingCountsResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-agents/pending-counts?` and deserializes to `GetPendingCountsResponse`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `GetPendingCountsResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
