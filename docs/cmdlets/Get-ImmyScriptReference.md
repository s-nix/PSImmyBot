---
title: Get-ImmyScriptReference
---

# Get-ImmyScriptReference

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetScriptReference` |
| Source | `Cmdlets/GetScriptReference.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/local/{ScriptId}/references? |
| Return Type | List<[ScriptReference](../models/ScriptReference.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/local/{ScriptId}/references?` and deserializes to List<[ScriptReference](../models/ScriptReference.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ScriptReference](../models/ScriptReference.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
