---
title: Get-ScriptReferenceCounts
---

# Get-ScriptReferenceCounts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetScriptReferenceCounts` |
| Source | `Cmdlets/GetScriptReferenceCounts.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/references/count? |
| Return Type | `ScriptReferenceCounts` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/references/count?` and deserializes to `ScriptReferenceCounts`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Nullable`1` | True | — | All | None |
| ScriptType | `Nullable`1` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ScriptReferenceCounts` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
