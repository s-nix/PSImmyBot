---
title: New-ImmyCalculateTargetsRequest
---

# New-ImmyCalculateTargetsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCalculateTargetsRequest` |
| Source | `Cmdlets/NewCalculateTargetsRequest.cs` |
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
| OnboardingOnly | `Boolean` | True | — | All | None |
| PropagateToChildTenants | `Boolean` | True | — | All | None |
| ProviderClientGroupType | `Nullable`1` | False | — | All | None |
| ProviderDeviceGroupType | `Nullable`1` | False | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| Target | `String` | False | — | All | None |
| TargetGroupFilter | [TargetGroupFilter](../models/TargetGroupFilter.md) | True | — | All | None |
| TargetType | [TargetType](../models/TargetType.md) | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
