---
title: New-ComputerInventoryTaskScriptResult
---

# New-ComputerInventoryTaskScriptResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputerInventoryTaskScriptResult` |
| Source | `Cmdlets/NewComputerInventoryTaskScriptResult.cs` |
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
| Computer | [Computer](../models/Computer.md) | True | — | All | None |
| ComputerId | `Int32` | True | — | All | None |
| InventoryKey | `String` | False | — | All | None |
| LatestErrorResult | `Object` | False | — | All | None |
| LatestResultIsError | `Boolean` | True | — | All | None |
| LatestSuccessResult | `Object` | False | — | All | None |
| Timestamp | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
