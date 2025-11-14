---
title: Send-InventoryTaskPayload
---

# Send-InventoryTaskPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendInventoryTaskPayload` |
| Source | `Cmdlets/SendInventoryTaskPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/inventory-tasks/local/{Id}? |
| Return Type | [InventoryTaskPayload](../models/InventoryTaskPayload.md), [InventoryTaskResource](../models/InventoryTaskResource.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/inventory-tasks/local/{Id}?` and deserializes to [InventoryTaskPayload](../models/InventoryTaskPayload.md), [InventoryTaskResource](../models/InventoryTaskResource.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [InventoryTaskPayload](../models/InventoryTaskPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [InventoryTaskPayload](../models/InventoryTaskPayload.md), [InventoryTaskResource](../models/InventoryTaskResource.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
