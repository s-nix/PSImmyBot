---
title: New-ImmyTargetAssignment
---

# New-ImmyTargetAssignment

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTargetAssignment` |
| Source | `Cmdlets/NewTargetAssignment.cs` |
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
| AutoApprove | `Boolean` | True | — | All | None |
| ChangeRequests | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DesiredSoftwareState | [DesiredSoftwareState](../models/DesiredSoftwareState.md) | True | — | All | None |
| Excluded | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IntegrationPrompt | `String` | False | — | All | None |
| IntegrationTypeId | `String` | False | — | All | None |
| IsCore | `Boolean` | True | — | All | None |
| License | [License](../models/License.md) | True | — | All | None |
| LicenseId | `Nullable`1` | False | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceSpecifier | [MaintenanceSpecifier](../models/MaintenanceSpecifier.md) | True | — | All | None |
| MaintenanceTaskMode | [MaintenanceTaskMode](../models/MaintenanceTaskMode.md) | True | — | All | None |
| MaintenanceTaskParameterValues | `ICollection`1` | False | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Notes | [TargetAssignmentNotes](../models/TargetAssignmentNotes.md) | True | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| ParameterValueMigrationErrors | `String` | False | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderClientGroupType | `Nullable`1` | False | — | All | None |
| ProviderDeviceGroupType | `Nullable`1` | False | — | All | None |
| ProviderLink | [ProviderLink](../models/ProviderLink.md) | True | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| ProviderLinkIdForMaintenanceItem | `Nullable`1` | False | — | All | None |
| SoftwareId | `Nullable`1` | False | — | All | None |
| SoftwareProviderType | [SoftwareProviderType](../models/SoftwareProviderType.md) | True | — | All | None |
| SoftwareSemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareSemanticVersionString | `String` | False | — | All | None |
| SoftwareSpecifier | [SoftwareSpecifier](../models/SoftwareSpecifier.md) | True | — | All | None |
| SoftwareVersionId | `Int32` | True | — | All | None |
| SortOrder | `Int32` | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetCategory | [TargetCategory](../models/TargetCategory.md) | True | — | All | None |
| TargetEnforcement | [TargetEnforcement](../models/TargetEnforcement.md) | True | — | All | None |
| TargetGroupFilter | [TargetGroupFilter](../models/TargetGroupFilter.md) | True | — | All | None |
| TargetName | `String` | False | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TaskParameterValues | `IDictionary`2` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| Visibility | [TargetAssignmentVisibility](../models/TargetAssignmentVisibility.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
