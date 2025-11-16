---
title: New-ImmyUpdateGlobalTargetAssignmentPayload
---

# New-ImmyUpdateGlobalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateGlobalTargetAssignmentPayload` |
| Source | `Cmdlets/NewUpdateGlobalTargetAssignmentPayload.cs` |
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
| DesiredSoftwareState | [DesiredSoftwareState](../models/DesiredSoftwareState.md) | True | — | All | None |
| Excluded | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceTaskMode | [MaintenanceTaskMode](../models/MaintenanceTaskMode.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| OnboardingOnly | `Boolean` | True | — | All | None |
| SoftwareProviderType | [SoftwareProviderType](../models/SoftwareProviderType.md) | True | — | All | None |
| SoftwareSemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetCategory | [TargetCategory](../models/TargetCategory.md) | True | — | All | None |
| TargetEnforcement | [TargetEnforcement](../models/TargetEnforcement.md) | True | — | All | None |
| TargetGroupFilter | [TargetGroupFilter](../models/TargetGroupFilter.md) | True | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TaskParameterValues | `IDictionary`2` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
