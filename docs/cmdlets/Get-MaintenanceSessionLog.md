---
title: Get-MaintenanceSessionLog
---

# Get-MaintenanceSessionLog

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceSessionLog` |
| Source | `Cmdlets/GetMaintenanceSessionLog.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-sessions/{SessionId}/last-log? |
| Return Type | [GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-sessions/{SessionId}/last-log?` and deserializes to [GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SessionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetMaintenanceSessionLogResponse](../models/GetMaintenanceSessionLogResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
