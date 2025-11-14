---
title: Remove-InventoryTasksLocalScripts
---

# Remove-InventoryTasksLocalScripts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveInventoryTasksLocalScripts` |
| Source | `Cmdlets/RemoveInventoryTasksLocalScripts.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/inventory-tasks/local/{TaskId}/scripts/{InventoryKey}? |
| Return Type | `InventoryTaskResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/inventory-tasks/local/{TaskId}/scripts/{InventoryKey}?` and deserializes to `InventoryTaskResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| InventoryKey | `String` | True | — | All | None |
| TaskId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `InventoryTaskResource` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
