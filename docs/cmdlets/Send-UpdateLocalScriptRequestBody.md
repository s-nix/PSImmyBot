---
title: Send-UpdateLocalScriptRequestBody
---

# Send-UpdateLocalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateLocalScriptRequestBody` |
| Source | `Cmdlets/SendUpdateLocalScriptRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/local/{ScriptId}? |
| Return Type | [UpdateLocalScriptRequestBody](../models/UpdateLocalScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/local/{ScriptId}?` and deserializes to [UpdateLocalScriptRequestBody](../models/UpdateLocalScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IgnoreSyntaxErrors | `Nullable`1` | False | — | All | None |
| PayloadBody | [UpdateLocalScriptRequestBody](../models/UpdateLocalScriptRequestBody.md) | True | — | All | None |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateLocalScriptRequestBody](../models/UpdateLocalScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
