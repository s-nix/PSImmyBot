---
title: New-SessionJobArgs
---

# New-SessionJobArgs

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSessionJobArgs` |
| Source | `Cmdlets/NewSessionJobArgs.cs` |
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
| ActionIdToRerun | `Nullable`1` | False | — | All | None |
| AllowAccessToParentTenant | `Boolean` | True | — | All | None |
| AppliedOnConnect | `Boolean` | True | — | All | None |
| AutoConsentToReboots | `Boolean` | True | — | All | None |
| CacheGroupId | `Nullable`1` | False | — | All | None |
| CacheOnly | `Boolean` | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| DeploymentId | `Nullable`1` | False | — | All | None |
| DeploymentType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DetectionOnly | `Boolean` | True | — | All | None |
| EnqueuedSessionType | [EnqueuedSessionType](../models/EnqueuedSessionType.md) | True | — | All | None |
| HasSessionFeatureBeenTracked | `Boolean` | True | — | All | None |
| InstallWindowsUpdates | `Boolean` | True | — | All | None |
| InventoryOnly | `Boolean` | True | — | All | None |
| MaintenanceAgentUpdatesConfiguration | [MaintenanceAgentUpdatesConfiguration](../models/MaintenanceAgentUpdatesConfiguration.md) | True | — | All | None |
| MaintenanceEmailConfiguration | [MaintenanceEmailConfiguration](../models/MaintenanceEmailConfiguration.md) | True | — | All | None |
| MaintenanceItem | [MaintenanceItem](../models/MaintenanceItem.md) | True | — | All | None |
| MaintenanceOnboardingConfiguration | [MaintenanceOnboardingConfiguration](../models/MaintenanceOnboardingConfiguration.md) | True | — | All | None |
| MaintenanceSchedulingConfiguration | [MaintenanceSchedulingConfiguration](../models/MaintenanceSchedulingConfiguration.md) | True | — | All | None |
| ManuallyResumed | `Boolean` | True | — | All | None |
| ManuallyResumedByPersonId | `Nullable`1` | False | — | All | None |
| ManuallyTriggeredByUserId | `Nullable`1` | False | — | All | None |
| OfflineBehavior | [ComputerOfflineMaintenanceSessionBehavior](../models/ComputerOfflineMaintenanceSessionBehavior.md) | True | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| PromptTimeoutAction | [PromptTimeoutAction](../models/PromptTimeoutAction.md) | True | — | All | None |
| PromptTimeoutMinutes | `Int32` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| RebootPreference | [RebootPreference](../models/RebootPreference.md) | True | — | All | None |
| Repair | `Boolean` | True | — | All | None |
| RerunFromScheduleId | `Nullable`1` | False | — | All | None |
| RerunningAction | `Boolean` | True | — | All | None |
| ResolutionOnly | `Boolean` | True | — | All | None |
| RunInventoryInDetection | `Boolean` | True | — | All | None |
| ScheduledId | `Nullable`1` | False | — | All | None |
| SessionGroupId | `Nullable`1` | False | — | All | None |
| SuppressRebootsDuringBusinessHours | `Boolean` | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TerminalId | `Nullable`1` | False | — | All | None |
| UseWinningDeployment | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
