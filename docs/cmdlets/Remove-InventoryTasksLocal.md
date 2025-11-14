---
title: Remove-InventoryTasksLocal
---

# Remove-InventoryTasksLocal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveInventoryTasksLocal` |
| Source | `Cmdlets/RemoveInventoryTasksLocal.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/inventory-tasks/local/{Id}? |
| Return Type | `InventoryTaskResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/inventory-tasks/local/{Id}?` and deserializes to `InventoryTaskResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `InventoryTaskResource` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
