---
title: New-InventoryTaskScript
---

# New-InventoryTaskScript

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewInventoryTaskScript` |
| Source | `Cmdlets/NewInventoryTaskScript.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| FromProvider | `Boolean` | True | — | All | None |
| InventoryKey | `String` | False | — | All | None |
| InventoryTask | `InventoryTask` | True | — | All | None |
| InventoryTaskId | `Int32` | True | — | All | None |
| SaveDebugStream | `Boolean` | True | — | All | None |
| SaveInformationStream | `Boolean` | True | — | All | None |
| SaveVerboseStream | `Boolean` | True | — | All | None |
| SaveWarningStream | `Boolean` | True | — | All | None |
| Script | `Script` | True | — | All | None |
| ScriptId | `Int32` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
