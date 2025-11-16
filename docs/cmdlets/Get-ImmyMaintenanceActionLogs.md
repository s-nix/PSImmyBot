---
title: Get-ImmyMaintenanceActionLogs
---

# Get-ImmyMaintenanceActionLogs

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceActionLogs` |
| Source | `Cmdlets/GetMaintenanceActionLogs.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-actions/{ActionId}/logs? |
| Return Type | List<[GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-actions/{ActionId}/logs?` and deserializes to List<[GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ActionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
