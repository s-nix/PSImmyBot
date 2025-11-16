---
title: Send-ImmyMaintenanceTasksGlobalParamBlockFromParameters
---

# Send-ImmyMaintenanceTasksGlobalParamBlockFromParameters

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMaintenanceTasksGlobalParamBlockFromParameters` |
| Source | `Cmdlets/SendMaintenanceTasksGlobalParamBlockFromParameters.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/global/{Id}/param-block-from-parameters? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/global/{Id}/param-block-from-parameters?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
