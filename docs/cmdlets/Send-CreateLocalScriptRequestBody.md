---
title: Send-CreateLocalScriptRequestBody
---

# Send-CreateLocalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalScriptRequestBody` |
| Source | `Cmdlets/SendCreateLocalScriptRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/local? |
| Return Type | `CreateLocalScriptRequestBody, GetLocalScriptResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/local?` and deserializes to `CreateLocalScriptRequestBody, GetLocalScriptResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IgnoreSyntaxErrors | `Nullable`1` | False | — | All | None |
| PayloadBody | `CreateLocalScriptRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateLocalScriptRequestBody, GetLocalScriptResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
