---
title: Send-UpdateGlobalScriptRequestBody
---

# Send-UpdateGlobalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateGlobalScriptRequestBody` |
| Source | `Cmdlets/SendUpdateGlobalScriptRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/global/{ScriptId}? |
| Return Type | [UpdateGlobalScriptRequestBody](../models/UpdateGlobalScriptRequestBody.md), [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/global/{ScriptId}?` and deserializes to [UpdateGlobalScriptRequestBody](../models/UpdateGlobalScriptRequestBody.md), [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IgnoreSyntaxErrors | `Nullable`1` | False | — | All | None |
| PayloadBody | [UpdateGlobalScriptRequestBody](../models/UpdateGlobalScriptRequestBody.md) | True | — | All | None |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateGlobalScriptRequestBody](../models/UpdateGlobalScriptRequestBody.md), [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
