---
title: New-DxComputerInventoryScriptResult
---

# New-DxComputerInventoryScriptResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDxComputerInventoryScriptResult` |
| Source | `Cmdlets/NewDxComputerInventoryScriptResult.cs` |
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
| ComputerId | `Int32` | True | — | All | None |
| ComputerName | `String` | False | — | All | None |
| InventoryKey | `String` | False | — | All | None |
| LatestSuccessResult | `Object` | False | — | All | None |
| LatestSuccessResultJson | `String` | False | — | All | None |
| Success | `Boolean` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TenantName | `String` | False | — | All | None |
| TimestampUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
