---
title: New-ImmyCreateGlobalScriptRequestBody
---

# New-ImmyCreateGlobalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCreateGlobalScriptRequestBody` |
| Source | `Cmdlets/NewCreateGlobalScriptRequestBody.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Action | `String` | False | — | All | None |
| Name | `String` | False | — | All | None |
| OutputType | [ScriptOutputType](../models/ScriptOutputType.md) | True | — | All | None |
| ScriptCategory | [ScriptCategory](../models/ScriptCategory.md) | True | — | All | None |
| ScriptExecutionContext | [ScriptExecutionContext](../models/ScriptExecutionContext.md) | True | — | All | None |
| ScriptLanguage | [ScriptLanguage](../models/ScriptLanguage.md) | True | — | All | None |
| ScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| Timeout | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
