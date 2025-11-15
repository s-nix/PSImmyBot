---
title: Get-MaintenanceSessionLogs
---

# Get-MaintenanceSessionLogs

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceSessionLogs` |
| Source | `Cmdlets/GetMaintenanceSessionLogs.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-sessions/{SessionId}/logs? |
| Return Type | List<[GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-sessions/{SessionId}/logs?` and deserializes to List<[GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SessionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
