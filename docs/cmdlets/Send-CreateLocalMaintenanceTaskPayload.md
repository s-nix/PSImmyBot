---
title: Send-CreateLocalMaintenanceTaskPayload
---

# Send-CreateLocalMaintenanceTaskPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalMaintenanceTaskPayload` |
| Source | `Cmdlets/SendCreateLocalMaintenanceTaskPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/local? |
| Return Type | `CreateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/local?` and deserializes to `CreateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateLocalMaintenanceTaskPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
