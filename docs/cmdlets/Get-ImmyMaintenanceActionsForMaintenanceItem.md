---
title: Get-ImmyMaintenanceActionsForMaintenanceItem
---

# Get-ImmyMaintenanceActionsForMaintenanceItem

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceActionsForMaintenanceItem` |
| Source | `Cmdlets/GetMaintenanceActionsForMaintenanceItem.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-actions/maintenance-item? |
| Return Type | List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-actions/maintenance-item?` and deserializes to List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| MaintenanceIdentifier | `String` | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
