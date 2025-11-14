---
title: New-RunImmybotMaintenanceRequestBody
---

# New-RunImmybotMaintenanceRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewRunImmybotMaintenanceRequestBody` |
| Source | `Cmdlets/NewRunImmybotMaintenanceRequestBody.cs` |
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
| DesiredSoftwareState | `DesiredSoftwareState` | True | — | All | None |
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceTaskMode | `MaintenanceTaskMode` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| ProviderLinkIdForMaintenanceItem | `Nullable`1` | False | — | All | None |
| Repair | `Boolean` | True | — | All | None |
| SemanticVersion | `SemanticVersion` | True | — | All | None |
| SemanticVersionNormalized | `String` | False | — | All | None |
| SoftwareProviderType | `SoftwareProviderType` | True | — | All | None |
| SoftwareType | `SoftwareType` | True | — | All | None |
| TaskParameterValues | `IDictionary`2` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
