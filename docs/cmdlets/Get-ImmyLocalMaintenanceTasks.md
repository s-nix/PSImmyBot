---
title: Get-ImmyLocalMaintenanceTasks
---

# Get-ImmyLocalMaintenanceTasks

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalMaintenanceTasks` |
| Source | `Cmdlets/GetLocalMaintenanceTasks.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-tasks/local? |
| Return Type | List<[GetLocalMaintenanceTaskResponse](../models/GetLocalMaintenanceTaskResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-tasks/local?` and deserializes to List<[GetLocalMaintenanceTaskResponse](../models/GetLocalMaintenanceTaskResponse.md)>.
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

- List<[GetLocalMaintenanceTaskResponse](../models/GetLocalMaintenanceTaskResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
