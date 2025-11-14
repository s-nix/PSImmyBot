---
title: Send-CreateGlobalMaintenanceTaskPayload
---

# Send-CreateGlobalMaintenanceTaskPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalMaintenanceTaskPayload` |
| Source | `Cmdlets/SendCreateGlobalMaintenanceTaskPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/global? |
| Return Type | `CreateGlobalMaintenanceTaskPayload, GetGlobalMaintenanceTaskResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/global?` and deserializes to `CreateGlobalMaintenanceTaskPayload, GetGlobalMaintenanceTaskResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateGlobalMaintenanceTaskPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateGlobalMaintenanceTaskPayload, GetGlobalMaintenanceTaskResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
