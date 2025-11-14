---
title: Send-UpdateLocalMaintenanceTaskPayload
---

# Send-UpdateLocalMaintenanceTaskPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateLocalMaintenanceTaskPayload` |
| Source | `Cmdlets/SendUpdateLocalMaintenanceTaskPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/local/{Id}? |
| Return Type | `UpdateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/local/{Id}?` and deserializes to `UpdateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateLocalMaintenanceTaskPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
