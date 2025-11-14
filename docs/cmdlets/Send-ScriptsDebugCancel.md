---
title: Send-ScriptsDebugCancel
---

# Send-ScriptsDebugCancel

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendScriptsDebugCancel` |
| Source | `Cmdlets/SendScriptsDebugCancel.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/debug/cancel/{CancellationId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/debug/cancel/{CancellationId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| CancellationId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
