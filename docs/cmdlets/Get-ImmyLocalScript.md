---
title: Get-ImmyLocalScript
---

# Get-ImmyLocalScript

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalScript` |
| Source | `Cmdlets/GetLocalScript.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/local/{ScriptId}? |
| Return Type | [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/local/{ScriptId}?` and deserializes to [GetLocalScriptResponse](../models/GetLocalScriptResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
