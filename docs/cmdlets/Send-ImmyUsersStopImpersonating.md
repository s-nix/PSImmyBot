---
title: Send-ImmyUsersStopImpersonating
---

# Send-ImmyUsersStopImpersonating

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUsersStopImpersonating` |
| Source | `Cmdlets/SendUsersStopImpersonating.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/stop-impersonating? |
| Return Type | [OpResult](../models/OpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/stop-impersonating?` and deserializes to [OpResult](../models/OpResult.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [OpResult](../models/OpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
