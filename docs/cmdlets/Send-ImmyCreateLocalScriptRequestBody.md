---
title: Send-ImmyCreateLocalScriptRequestBody
---

# Send-ImmyCreateLocalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalScriptRequestBody` |
| Source | `Cmdlets/SendCreateLocalScriptRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/local? |
| Return Type | [CreateLocalScriptRequestBody](../models/CreateLocalScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/local?` and deserializes to [CreateLocalScriptRequestBody](../models/CreateLocalScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IgnoreSyntaxErrors | `Nullable`1` | False | — | All | None |
| PayloadBody | [CreateLocalScriptRequestBody](../models/CreateLocalScriptRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateLocalScriptRequestBody](../models/CreateLocalScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
