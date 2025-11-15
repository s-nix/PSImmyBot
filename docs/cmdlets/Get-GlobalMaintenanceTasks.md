---
title: Get-GlobalMaintenanceTasks
---

# Get-GlobalMaintenanceTasks

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalMaintenanceTasks` |
| Source | `Cmdlets/GetGlobalMaintenanceTasks.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-tasks/global? |
| Return Type | List<[GetGlobalMaintenanceTaskResponse](../models/GetGlobalMaintenanceTaskResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-tasks/global?` and deserializes to List<[GetGlobalMaintenanceTaskResponse](../models/GetGlobalMaintenanceTaskResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Filters | `String` | False | — | All | None |
| Page | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| Sorts | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetGlobalMaintenanceTaskResponse](../models/GetGlobalMaintenanceTaskResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
