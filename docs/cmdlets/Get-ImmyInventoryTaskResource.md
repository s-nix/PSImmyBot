---
title: Get-ImmyInventoryTaskResource
---

# Get-ImmyInventoryTaskResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetInventoryTaskResource` |
| Source | `Cmdlets/GetInventoryTaskResource.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/inventory-tasks? |
| Return Type | List<[InventoryTaskResource](../models/InventoryTaskResource.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/inventory-tasks?` and deserializes to List<[InventoryTaskResource](../models/InventoryTaskResource.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[InventoryTaskResource](../models/InventoryTaskResource.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
