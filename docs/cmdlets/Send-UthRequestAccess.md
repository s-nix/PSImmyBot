---
title: Send-UthRequestAccess
---

# Send-UthRequestAccess

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUthRequestAccess` |
| Source | `Cmdlets/SendUthRequestAccess.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/auth/request-access? |
| Return Type | `CommandResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/auth/request-access?` and deserializes to `CommandResult`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `CommandResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
