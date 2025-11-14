---
title: New-MaintenanceSchedulingConfiguration
---

# New-MaintenanceSchedulingConfiguration

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceSchedulingConfiguration` |
| Source | `Cmdlets/NewMaintenanceSchedulingConfiguration.cs` |
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
| MaintenanceTime | `String` | False | — | All | None |
| OfflineBehavior | `ComputerOfflineMaintenanceSessionBehavior` | True | — | All | None |
| ScheduleExecutionAfterActiveHours | `Boolean` | True | — | All | None |
| Time | `String` | False | — | All | None |
| TimeZoneInfoId | `String` | False | — | All | None |
| UseComputersTimezoneForExecution | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
