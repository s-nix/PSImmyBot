---
title: Send-ImmySystemPullUpdate
---

# Send-ImmySystemPullUpdate

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSystemPullUpdate` |
| Source | `Cmdlets/SendSystemPullUpdate.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/system/pull-update? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/system/pull-update?`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
