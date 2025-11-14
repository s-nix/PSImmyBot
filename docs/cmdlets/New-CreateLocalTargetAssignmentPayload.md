---
title: New-CreateLocalTargetAssignmentPayload
---

# New-CreateLocalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCreateLocalTargetAssignmentPayload` |
| Source | `Cmdlets/NewCreateLocalTargetAssignmentPayload.cs` |
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
| DesiredSoftwareState | `DesiredSoftwareState` | True | — | All | None |
| Excluded | `Boolean` | True | — | All | None |
| LicenseId | `Nullable`1` | False | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceTaskMode | `MaintenanceTaskMode` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderClientGroupType | `Nullable`1` | False | — | All | None |
| ProviderDeviceGroupType | `Nullable`1` | False | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| ProviderLinkIdForMaintenanceItem | `Nullable`1` | False | — | All | None |
| SoftwareProviderType | `SoftwareProviderType` | True | — | All | None |
| SoftwareSemanticVersion | `SemanticVersion` | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetCategory | `TargetCategory` | True | — | All | None |
| TargetEnforcement | `TargetEnforcement` | True | — | All | None |
| TargetGroupFilter | `TargetGroupFilter` | True | — | All | None |
| TargetType | `TargetType` | True | — | All | None |
| TaskParameterValues | `IDictionary`2` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| Visibility | `TargetAssignmentVisibilityPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
