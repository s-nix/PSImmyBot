---
title: Get-ImmyMaintenanceSessionPhase
---

# Get-ImmyMaintenanceSessionPhase

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceSessionPhase` |
| Source | `Cmdlets/GetMaintenanceSessionPhase.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-sessions/{SessionId}/phases? |
| Return Type | List<[GetMaintenanceSessionPhaseResponse](../models/GetMaintenanceSessionPhaseResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-sessions/{SessionId}/phases?` and deserializes to List<[GetMaintenanceSessionPhaseResponse](../models/GetMaintenanceSessionPhaseResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SessionId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetMaintenanceSessionPhaseResponse](../models/GetMaintenanceSessionPhaseResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
