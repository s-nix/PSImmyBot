---
title: Get-GlobalMaintenanceTask
---

# Get-GlobalMaintenanceTask

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalMaintenanceTask` |
| Source | `Cmdlets/GetGlobalMaintenanceTask.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-tasks/global/{Id}? |
| Return Type | `GetGlobalMaintenanceTaskResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-tasks/global/{Id}?` and deserializes to `GetGlobalMaintenanceTaskResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetGlobalMaintenanceTaskResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
