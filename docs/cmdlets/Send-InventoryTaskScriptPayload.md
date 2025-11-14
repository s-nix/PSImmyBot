---
title: Send-InventoryTaskScriptPayload
---

# Send-InventoryTaskScriptPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendInventoryTaskScriptPayload` |
| Source | `Cmdlets/SendInventoryTaskScriptPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/inventory-tasks/local/{Id}/scripts? |
| Return Type | [InventoryTaskScriptPayload](../models/InventoryTaskScriptPayload.md), [InventoryTaskScriptResource](../models/InventoryTaskScriptResource.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/inventory-tasks/local/{Id}/scripts?` and deserializes to [InventoryTaskScriptPayload](../models/InventoryTaskScriptPayload.md), [InventoryTaskScriptResource](../models/InventoryTaskScriptResource.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [InventoryTaskScriptPayload](../models/InventoryTaskScriptPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [InventoryTaskScriptPayload](../models/InventoryTaskScriptPayload.md), [InventoryTaskScriptResource](../models/InventoryTaskScriptResource.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
