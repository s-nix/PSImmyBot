---
title: New-ImmyStartEditorServicesRequest
---

# New-ImmyStartEditorServicesRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewStartEditorServicesRequest` |
| Source | `Cmdlets/NewStartEditorServicesRequest.cs` |
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
| ScriptCategory | [ScriptCategory](../models/ScriptCategory.md) | True | — | All | None |
| ScriptExecutionContext | [ScriptExecutionContext](../models/ScriptExecutionContext.md) | True | — | All | None |
| ScriptId | `Nullable`1` | False | — | All | None |
| ScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| TerminalId | `Guid` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
