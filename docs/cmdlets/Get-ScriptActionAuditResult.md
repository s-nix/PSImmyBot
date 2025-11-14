---
title: Get-ScriptActionAuditResult
---

# Get-ScriptActionAuditResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetScriptActionAuditResult` |
| Source | `Cmdlets/GetScriptActionAuditResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/global/{ScriptId}/audit? |
| Return Type | `ScriptActionAuditResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/global/{ScriptId}/audit?` and deserializes to `ScriptActionAuditResult`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Int32` | True | — | All | None |
| Skip | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ScriptActionAuditResult` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
