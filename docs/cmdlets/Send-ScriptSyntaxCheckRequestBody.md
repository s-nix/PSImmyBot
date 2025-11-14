---
title: Send-ScriptSyntaxCheckRequestBody
---

# Send-ScriptSyntaxCheckRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendScriptSyntaxCheckRequestBody` |
| Source | `Cmdlets/SendScriptSyntaxCheckRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/syntax-check? |
| Return Type | [ScriptSyntaxCheckRequestBody](../models/ScriptSyntaxCheckRequestBody.md), [SyntaxCheckerResult](../models/SyntaxCheckerResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/syntax-check?` and deserializes to [ScriptSyntaxCheckRequestBody](../models/ScriptSyntaxCheckRequestBody.md), [SyntaxCheckerResult](../models/SyntaxCheckerResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ScriptSyntaxCheckRequestBody](../models/ScriptSyntaxCheckRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ScriptSyntaxCheckRequestBody](../models/ScriptSyntaxCheckRequestBody.md), [SyntaxCheckerResult](../models/SyntaxCheckerResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
