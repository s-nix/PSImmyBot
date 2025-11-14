---
title: Get-MaintenanceSession
---

# Get-MaintenanceSession

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceSession` |
| Source | `Cmdlets/GetMaintenanceSession.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-sessions/{SessionId}? |
| Return Type | `GetMaintenanceSessionResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-sessions/{SessionId}?` and deserializes to `GetMaintenanceSessionResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IncludeActionActivities | `Nullable`1` | False | — | All | None |
| IncludeActions | `Nullable`1` | False | — | All | None |
| IncludeStages | `Nullable`1` | False | — | All | None |
| SessionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetMaintenanceSessionResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
