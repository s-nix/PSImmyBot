---
title: New-MaintenanceTaskParameterValueDetails
---

# New-MaintenanceTaskParameterValueDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceTaskParameterValueDetails` |
| Source | `Cmdlets/NewMaintenanceTaskParameterValueDetails.cs` |
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
| DeploymentId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceTaskId | `Int32` | True | — | All | None |
| MaintenanceTaskParameterId | `Int32` | True | — | All | None |
| MaintenanceTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
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
