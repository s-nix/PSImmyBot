---
title: New-GetScheduleResponse
---

# New-GetScheduleResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetScheduleResponse` |
| Source | `Cmdlets/NewGetScheduleResponse.cs` |
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
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| CustomCronExpression | `String` | False | — | All | None |
| Day | `Nullable`1` | False | — | All | None |
| Disabled | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceTime | `String` | False | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| NextOccurenceDate | `Nullable`1` | False | — | All | None |
| OfflineBehavior | [ComputerOfflineMaintenanceSessionBehavior](../models/ComputerOfflineMaintenanceSessionBehavior.md) | True | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| PromptTimeoutAction | [PromptTimeoutAction](../models/PromptTimeoutAction.md) | True | — | All | None |
| PromptTimeoutMinutes | `Int32` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderClientGroupType | `Nullable`1` | False | — | All | None |
| ProviderDeviceGroupType | `Nullable`1` | False | — | All | None |
| ProviderLink | [GetProviderLinkResponse](../models/GetProviderLinkResponse.md) | True | — | All | None |
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
| TargetGroupFilterName | `String` | False | — | All | None |
| TargetMissing | `Boolean` | True | — | All | None |
| TargetScopeName | `String` | False | — | All | None |
| TargetText | `String` | False | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TargetTypeDescription | `String` | False | — | All | None |
| TargetTypeMissing | `Boolean` | True | — | All | None |
| TargetTypeName | `String` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TenantMissing | `Boolean` | True | — | All | None |
| Time | `String` | False | — | All | None |
| TimeZoneInfoId | `String` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByName | `String` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |
| UseComputersTimezoneForExecution | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
