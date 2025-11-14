---
title: New-GetTargetAssignmentTypeResponse
---

# New-GetTargetAssignmentTypeResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetTargetAssignmentTypeResponse` |
| Source | `Cmdlets/NewGetTargetAssignmentTypeResponse.cs` |
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
| DesiredSoftwareState | [DesiredSoftwareState](../models/DesiredSoftwareState.md) | True | — | All | None |
| MaintenanceTaskMode | [MaintenanceTaskMode](../models/MaintenanceTaskMode.md) | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| Target | `String` | False | — | All | None |
| TargetEnforcement | [TargetEnforcement](../models/TargetEnforcement.md) | True | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
