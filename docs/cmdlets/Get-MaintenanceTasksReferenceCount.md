---
title: Get-MaintenanceTasksReferenceCount
---

# Get-MaintenanceTasksReferenceCount

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceTasksReferenceCount` |
| Source | `Cmdlets/GetMaintenanceTasksReferenceCount.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-tasks/reference-count? |
| Return Type | `int` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-tasks/reference-count?` and deserializes to `int`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| MaintenanceTaskId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskType | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `int` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
