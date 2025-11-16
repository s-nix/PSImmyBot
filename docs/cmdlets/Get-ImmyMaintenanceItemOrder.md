---
title: Get-ImmyMaintenanceItemOrder
---

# Get-ImmyMaintenanceItemOrder

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceItemOrder` |
| Source | `Cmdlets/GetMaintenanceItemOrder.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/maintenance-item-orders? |
| Return Type | List<[MaintenanceItemOrder](../models/MaintenanceItemOrder.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/maintenance-item-orders?` and deserializes to List<[MaintenanceItemOrder](../models/MaintenanceItemOrder.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[MaintenanceItemOrder](../models/MaintenanceItemOrder.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
