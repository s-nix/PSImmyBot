---
title: Get-LocalMaintenanceTask
---

# Get-LocalMaintenanceTask

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalMaintenanceTask` |
| Source | `Cmdlets/GetLocalMaintenanceTask.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-tasks/local/{Id}? |
| Return Type | [GetLocalMaintenanceTaskResponse](../models/GetLocalMaintenanceTaskResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-tasks/local/{Id}?` and deserializes to [GetLocalMaintenanceTaskResponse](../models/GetLocalMaintenanceTaskResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetLocalMaintenanceTaskResponse](../models/GetLocalMaintenanceTaskResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
