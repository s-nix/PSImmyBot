---
title: Send-ImmyMaintenanceTasksLocalMigrateLocalToGlobal
---

# Send-ImmyMaintenanceTasksLocalMigrateLocalToGlobal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMaintenanceTasksLocalMigrateLocalToGlobal` |
| Source | `Cmdlets/SendMaintenanceTasksLocalMigrateLocalToGlobal.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/local/{Id}/migrate-local-to-global? |
| Return Type | `int` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/local/{Id}/migrate-local-to-global?` and deserializes to `int`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `int` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
