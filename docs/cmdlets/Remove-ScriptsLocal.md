---
title: Remove-ScriptsLocal
---

# Remove-ScriptsLocal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveScriptsLocal` |
| Source | `Cmdlets/RemoveScriptsLocal.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/scripts/local/{ScriptId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/scripts/local/{ScriptId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
