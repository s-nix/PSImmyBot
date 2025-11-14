---
title: New-Schedule
---

# New-Schedule

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSchedule` |
| Source | `Cmdlets/NewSchedule.cs` |
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
| AllowAccessToMspResources | `Boolean` | True | — | All | None |
| AllowAccessToParentTenant | `Boolean` | True | — | All | None |
| ApplyWindowsUpdates | `Boolean` | True | — | All | None |
| AutoConsentToReboots | `Boolean` | True | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| CustomCronExpression | `String` | False | — | All | None |
| Day | `Nullable`1` | False | — | All | None |
| Disabled | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceTime | `String` | False | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| OfflineBehavior | [ComputerOfflineMaintenanceSessionBehavior](../models/ComputerOfflineMaintenanceSessionBehavior.md) | True | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| PromptTimeoutAction | [PromptTimeoutAction](../models/PromptTimeoutAction.md) | True | — | All | None |
| PromptTimeoutMinutes | `Int32` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderClientGroupType | `Nullable`1` | False | — | All | None |
| ProviderDeviceGroupType | `Nullable`1` | False | — | All | None |
| ProviderLink | [ProviderLink](../models/ProviderLink.md) | True | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| RebootPreference | [RebootPreference](../models/RebootPreference.md) | True | — | All | None |
| ScheduleExecutionAfterActiveHours | `Boolean` | True | — | All | None |
| SendDetectionEmail | `Boolean` | True | — | All | None |
| SendDetectionEmailWhenAllActionsAreCompliant | `Boolean` | True | — | All | None |
| SendFollowUpEmail | `Boolean` | True | — | All | None |
| SendFollowUpOnlyIfActionNeeded | `Boolean` | True | — | All | None |
| ShowMaintenanceActions | `Boolean` | True | — | All | None |
| ShowPostponeButton | `Boolean` | True | — | All | None |
| ShowRunNowButton | `Boolean` | True | — | All | None |
| SuppressRebootsDuringBusinessHours | `Boolean` | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetCategory | [TargetCategory](../models/TargetCategory.md) | True | — | All | None |
| TargetGroupFilter | [TargetGroupFilter](../models/TargetGroupFilter.md) | True | — | All | None |
| TargetName | `String` | False | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| Time | `String` | False | — | All | None |
| TimeZoneInfoId | `String` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UseComputersTimezoneForExecution | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
