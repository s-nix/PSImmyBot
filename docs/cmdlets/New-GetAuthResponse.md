---
title: New-GetAuthResponse
---

# New-GetAuthResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetAuthResponse` |
| Source | `Cmdlets/NewGetAuthResponse.cs` |
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
| Addons | `ICollection`1` | False | — | All | None |
| BackendRegAppId | `String` | False | — | All | None |
| CanManageCrossTenantDeployments | `Boolean` | True | — | All | None |
| Claims | `ICollection`1` | False | — | All | None |
| CurrentReleaseReleaseChannel | [ReleaseChannel](../models/ReleaseChannel.md) | True | — | All | None |
| CurrentReleaseVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| DaysLeftInTrial | `Nullable`1` | False | — | All | None |
| DevInstanceDetails | [DevInstanceDetails](../models/DevInstanceDetails.md) | True | — | All | None |
| DisplayName | `String` | False | — | All | None |
| Email | `String` | False | — | All | None |
| Features | `ICollection`1` | False | — | All | None |
| FirstName | `String` | False | — | All | None |
| GlobalPublicMediaContainerName | `String` | False | — | All | None |
| GlobalSoftwareEndpoint | `String` | False | — | All | None |
| HasManagementAccess | `Boolean` | True | — | All | None |
| ImmyProduct | `String` | False | — | All | None |
| Impersonating | `Boolean` | True | — | All | None |
| InstanceReleaseChannel | [ReleaseChannel](../models/ReleaseChannel.md) | True | — | All | None |
| InstanceUpdateHasFailed | `Boolean` | True | — | All | None |
| InstanceUpdateSource | `String` | False | — | All | None |
| IsAdmin | `Boolean` | True | — | All | None |
| IsImmense | `Boolean` | True | — | All | None |
| IsImmySupportAccessEnabled | `Boolean` | True | — | All | None |
| IsInstanceRestarting | `Boolean` | True | — | All | None |
| IsInstanceUpdating | `Boolean` | True | — | All | None |
| IsMsp | `Boolean` | True | — | All | None |
| IsSupportTechnician | `Boolean` | True | — | All | None |
| LastName | `String` | False | — | All | None |
| LocalPublicMediaContainerName | `String` | False | — | All | None |
| LocalSoftwareEndpoint | `String` | False | — | All | None |
| MaximumTrackableComputers | `Nullable`1` | False | — | All | None |
| MaxRunningSessionCount | `Int32` | True | — | All | None |
| OpenAccessRequestCount | `Int32` | True | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| PlanId | `String` | False | — | All | None |
| PlanPrice | `Nullable`1` | False | — | All | None |
| PlanQuantity | `Nullable`1` | False | — | All | None |
| Status | [SubscriptionStatus](../models/SubscriptionStatus.md) | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TenantName | `String` | False | — | All | None |
| TrialEndUtc | `Nullable`1` | False | — | All | None |
| TrialStartUtc | `Nullable`1` | False | — | All | None |
| UpdateAvailable | `Boolean` | True | — | All | None |
| UserId | `Int32` | True | — | All | None |
| UserLevelAuthSelected | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
