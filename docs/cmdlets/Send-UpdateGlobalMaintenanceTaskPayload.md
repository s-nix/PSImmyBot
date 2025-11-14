---
title: Send-UpdateGlobalMaintenanceTaskPayload
---

# Send-UpdateGlobalMaintenanceTaskPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateGlobalMaintenanceTaskPayload` |
| Source | `Cmdlets/SendUpdateGlobalMaintenanceTaskPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/global/{Id}? |
| Return Type | [UpdateGlobalMaintenanceTaskPayload](../models/UpdateGlobalMaintenanceTaskPayload.md), [GetGlobalMaintenanceTaskResponse](../models/GetGlobalMaintenanceTaskResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/global/{Id}?` and deserializes to [UpdateGlobalMaintenanceTaskPayload](../models/UpdateGlobalMaintenanceTaskPayload.md), [GetGlobalMaintenanceTaskResponse](../models/GetGlobalMaintenanceTaskResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateGlobalMaintenanceTaskPayload](../models/UpdateGlobalMaintenanceTaskPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateGlobalMaintenanceTaskPayload](../models/UpdateGlobalMaintenanceTaskPayload.md), [GetGlobalMaintenanceTaskResponse](../models/GetGlobalMaintenanceTaskResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
