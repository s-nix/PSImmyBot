---
title: Send-SystemIsImmySupportAccessGranted
---

# Send-SystemIsImmySupportAccessGranted

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSystemIsImmySupportAccessGranted` |
| Source | `Cmdlets/SendSystemIsImmySupportAccessGranted.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/system/is-immy-support-access-granted? |
| Return Type | `bool` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/system/is-immy-support-access-granted?` and deserializes to `bool`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `bool` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
