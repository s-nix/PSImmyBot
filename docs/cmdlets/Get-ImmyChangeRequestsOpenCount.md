---
title: Get-ImmyChangeRequestsOpenCount
---

# Get-ImmyChangeRequestsOpenCount

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetChangeRequestsOpenCount` |
| Source | `Cmdlets/GetChangeRequestsOpenCount.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/change-requests/open-count? |
| Return Type | `int` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/change-requests/open-count?` and deserializes to `int`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `int` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
