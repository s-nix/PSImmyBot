---
title: New-MaintenanceTaskParameter
---

# New-MaintenanceTaskParameter

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceTaskParameter` |
| Source | `Cmdlets/NewMaintenanceTaskParameter.cs` |
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
| DataType | [MaintenanceTaskParameterType](../models/MaintenanceTaskParameterType.md) | True | — | All | None |
| DefaultMedia | [Media](../models/Media.md) | True | — | All | None |
| DefaultMediaDatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DefaultMediaId | `Nullable`1` | False | — | All | None |
| DefaultValue | `String` | False | — | All | None |
| Hidden | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceTask | [MaintenanceTask](../models/MaintenanceTask.md) | True | — | All | None |
| MaintenanceTaskId | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| Order | `Int32` | True | — | All | None |
| Required | `Boolean` | True | — | All | None |
| SelectableValues | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
