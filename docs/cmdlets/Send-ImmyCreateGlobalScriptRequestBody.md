---
title: Send-ImmyCreateGlobalScriptRequestBody
---

# Send-ImmyCreateGlobalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalScriptRequestBody` |
| Source | `Cmdlets/SendCreateGlobalScriptRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/global? |
| Return Type | [CreateGlobalScriptRequestBody](../models/CreateGlobalScriptRequestBody.md), [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/global?` and deserializes to [CreateGlobalScriptRequestBody](../models/CreateGlobalScriptRequestBody.md), [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IgnoreSyntaxErrors | `Nullable`1` | False | — | All | None |
| PayloadBody | [CreateGlobalScriptRequestBody](../models/CreateGlobalScriptRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateGlobalScriptRequestBody](../models/CreateGlobalScriptRequestBody.md), [GetGlobalScriptResponse](../models/GetGlobalScriptResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
