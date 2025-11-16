---
title: Get-ImmyPendingCounts
---

# Get-ImmyPendingCounts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetPendingCounts` |
| Source | `Cmdlets/GetPendingCounts.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-agents/pending-counts? |
| Return Type | [GetPendingCountsResponse](../models/GetPendingCountsResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-agents/pending-counts?` and deserializes to [GetPendingCountsResponse](../models/GetPendingCountsResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetPendingCountsResponse](../models/GetPendingCountsResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
