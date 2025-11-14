---
title: New-RunImmyServiceRequestBody
---

# New-RunImmyServiceRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewRunImmyServiceRequestBody` |
| Source | `Cmdlets/NewRunImmyServiceRequestBody.cs` |
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
| AllowAccessToParentTenant | `Boolean` | True | — | All | None |
| AutoConsentToReboots | `Boolean` | True | — | All | None |
| CacheOnly | `Boolean` | True | — | All | None |
| Computers | `ICollection`1` | False | — | All | None |
| DeploymentId | `Nullable`1` | False | — | All | None |
| DeploymentType | `DatabaseType` | True | — | All | None |
| DetectionOnly | `Boolean` | True | — | All | None |
| FullMaintenance | `Boolean` | True | — | All | None |
| InventoryOnly | `Boolean` | True | — | All | None |
| LicenseId | `Nullable`1` | False | — | All | None |
| MaintenanceParams | `RunImmybotMaintenanceRequestBody` | True | — | All | None |
| OfflineBehavior | `ComputerOfflineMaintenanceSessionBehavior` | True | — | All | None |
| Persons | `ICollection`1` | False | — | All | None |
| PromptTimeoutAction | `PromptTimeoutAction` | True | — | All | None |
| PromptTimeoutMinutes | `Int32` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderLinkIdForAgentUpdates | `Nullable`1` | False | — | All | None |
| RebootPreference | `RebootPreference` | True | — | All | None |
| ResolutionOnly | `Boolean` | True | — | All | None |
| RunInventoryInDetection | `Boolean` | True | — | All | None |
| ScheduleExecutionAfterActiveHours | `Boolean` | True | — | All | None |
| SendDetectionEmail | `Boolean` | True | — | All | None |
| SendDetectionEmailWhenAllActionsAreCompliant | `Boolean` | True | — | All | None |
| SendFollowUpEmail | `Boolean` | True | — | All | None |
| SendFollowUpOnlyIfActionNeeded | `Boolean` | True | — | All | None |
| SessionGroupId | `Nullable`1` | False | — | All | None |
| ShowMaintenanceActions | `Boolean` | True | — | All | None |
| ShowPostponeButton | `Boolean` | True | — | All | None |
| ShowRunNowButton | `Boolean` | True | — | All | None |
| SkipBackgroundJob | `Boolean` | True | — | All | None |
| SuppressRebootsDuringBusinessHours | `Boolean` | True | — | All | None |
| Tenants | `ICollection`1` | False | — | All | None |
| TimeZoneInfoId | `String` | False | — | All | None |
| UpdateTime | `String` | False | — | All | None |
| UseComputersTimezoneForExecution | `Boolean` | True | — | All | None |
| UseWinningDeployment | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
