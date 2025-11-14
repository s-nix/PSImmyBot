---
title: Get-MaintenanceAction
---

# Get-MaintenanceAction

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceAction` |
| Source | `Cmdlets/GetMaintenanceAction.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-actions/computer/{ComputerId}/needs-attention? |
| Return Type | List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-actions/computer/{ComputerId}/needs-attention?` and deserializes to List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
