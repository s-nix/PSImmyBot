---
title: New-GlobalTargetAssignmentResource
---

# New-GlobalTargetAssignmentResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGlobalTargetAssignmentResource` |
| Source | `Cmdlets/NewGlobalTargetAssignmentResource.cs` |
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
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DesiredSoftwareState | [DesiredSoftwareState](../models/DesiredSoftwareState.md) | True | — | All | None |
| Excluded | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IntegrationPrompt | `String` | False | — | All | None |
| IntegrationTypeId | `String` | False | — | All | None |
| IsCore | `Boolean` | True | — | All | None |
| LicenseId | `Nullable`1` | False | — | All | None |
| LicenseName | `String` | False | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceTaskMode | [MaintenanceTaskMode](../models/MaintenanceTaskMode.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Notes | `String` | False | — | All | None |
| NotesUpdatedByUserName | `String` | False | — | All | None |
| NotesUpdatedUtc | `Nullable`1` | False | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderClientGroupType | `Nullable`1` | False | — | All | None |
| ProviderDeviceGroupType | `Nullable`1` | False | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| ProviderLinkIdForMaintenanceItem | `Nullable`1` | False | — | All | None |
| SoftwareProviderType | [SoftwareProviderType](../models/SoftwareProviderType.md) | True | — | All | None |
| SoftwareSemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareSemanticVersionString | `String` | False | — | All | None |
| SortOrder | `Int32` | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetCategory | [TargetCategory](../models/TargetCategory.md) | True | — | All | None |
| TargetEnforcement | [TargetEnforcement](../models/TargetEnforcement.md) | True | — | All | None |
| TargetGroupFilter | [TargetGroupFilter](../models/TargetGroupFilter.md) | True | — | All | None |
| TargetGroupFilterName | `String` | False | — | All | None |
| TargetMissing | `Boolean` | True | — | All | None |
| TargetName | `String` | False | — | All | None |
| TargetScopeName | `String` | False | — | All | None |
| TargetText | `String` | False | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TargetTypeDescription | `String` | False | — | All | None |
| TargetTypeMissing | `Boolean` | True | — | All | None |
| TargetTypeName | `String` | False | — | All | None |
| TaskParameterValues | `IDictionary`2` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TenantMissing | `Boolean` | True | — | All | None |
| UpdatedBy | `String` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
