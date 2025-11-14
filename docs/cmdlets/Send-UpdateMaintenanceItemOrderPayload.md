---
title: Send-UpdateMaintenanceItemOrderPayload
---

# Send-UpdateMaintenanceItemOrderPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateMaintenanceItemOrderPayload` |
| Source | `Cmdlets/SendUpdateMaintenanceItemOrderPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/update-maintenance-item-order? |
| Return Type | `UpdateMaintenanceItemOrderPayload, MaintenanceItemOrder` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/update-maintenance-item-order?` and deserializes to `UpdateMaintenanceItemOrderPayload, MaintenanceItemOrder`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `UpdateMaintenanceItemOrderPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateMaintenanceItemOrderPayload, MaintenanceItemOrder` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
