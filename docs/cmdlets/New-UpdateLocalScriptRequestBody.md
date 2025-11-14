---
title: New-UpdateLocalScriptRequestBody
---

# New-UpdateLocalScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateLocalScriptRequestBody` |
| Source | `Cmdlets/NewUpdateLocalScriptRequestBody.cs` |
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
| OutputType | `ScriptOutputType` | True | — | All | None |
| ScriptCacheName | `String` | False | — | All | None |
| ScriptCategory | `ScriptCategory` | True | — | All | None |
| ScriptExecutionContext | `ScriptExecutionContext` | True | — | All | None |
| ScriptLanguage | `ScriptLanguage` | True | — | All | None |
| ScriptType | `DatabaseType` | True | — | All | None |
| Tenants | `ICollection`1` | False | — | All | None |
| Timeout | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
