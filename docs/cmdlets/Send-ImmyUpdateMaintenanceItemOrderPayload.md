---
title: Send-ImmyUpdateMaintenanceItemOrderPayload
---

# Send-ImmyUpdateMaintenanceItemOrderPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateMaintenanceItemOrderPayload` |
| Source | `Cmdlets/SendUpdateMaintenanceItemOrderPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/update-maintenance-item-order? |
| Return Type | [UpdateMaintenanceItemOrderPayload](../models/UpdateMaintenanceItemOrderPayload.md), [MaintenanceItemOrder](../models/MaintenanceItemOrder.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/update-maintenance-item-order?` and deserializes to [UpdateMaintenanceItemOrderPayload](../models/UpdateMaintenanceItemOrderPayload.md), [MaintenanceItemOrder](../models/MaintenanceItemOrder.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateMaintenanceItemOrderPayload](../models/UpdateMaintenanceItemOrderPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateMaintenanceItemOrderPayload](../models/UpdateMaintenanceItemOrderPayload.md), [MaintenanceItemOrder](../models/MaintenanceItemOrder.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
