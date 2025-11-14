---
title: New-MaintenanceTaskParameterValue
---

# New-MaintenanceTaskParameterValue

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceTaskParameterValue` |
| Source | `Cmdlets/NewMaintenanceTaskParameterValue.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AllowOverrideFromComputerOnboarding | `Boolean` | True | — | All | None |
| Deployment | [TargetAssignment](../models/TargetAssignment.md) | True | — | All | None |
| DeploymentId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceTask | [MaintenanceTask](../models/MaintenanceTask.md) | True | — | All | None |
| MaintenanceTaskId | `Int32` | True | — | All | None |
| MaintenanceTaskParameter | [MaintenanceTaskParameter](../models/MaintenanceTaskParameter.md) | True | — | All | None |
| MaintenanceTaskParameterId | `Int32` | True | — | All | None |
| MaintenanceTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| Media | [Media](../models/Media.md) | True | — | All | None |
| MediaDatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| MediaId | `Nullable`1` | False | — | All | None |
| ParameterName | `String` | False | — | All | None |
| ParameterType | [MaintenanceTaskParameterType](../models/MaintenanceTaskParameterType.md) | True | — | All | None |
| Value | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
