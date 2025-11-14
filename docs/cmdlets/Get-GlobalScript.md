---
title: Get-GlobalScript
---

# Get-GlobalScript

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalScript` |
| Source | `Cmdlets/GetGlobalScript.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/global/{ScriptId}? |
| Return Type | [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/global/{ScriptId}?` and deserializes to [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
