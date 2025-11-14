---
title: Send-DuplicateMaintenanceTaskRequestbody
---

# Send-DuplicateMaintenanceTaskRequestbody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDuplicateMaintenanceTaskRequestbody` |
| Source | `Cmdlets/SendDuplicateMaintenanceTaskRequestbody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/duplicate? |
| Return Type | `DuplicateMaintenanceTaskRequestbody, GetLocalMaintenanceTaskResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/duplicate?` and deserializes to `DuplicateMaintenanceTaskRequestbody, GetLocalMaintenanceTaskResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `DuplicateMaintenanceTaskRequestbody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `DuplicateMaintenanceTaskRequestbody, GetLocalMaintenanceTaskResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
