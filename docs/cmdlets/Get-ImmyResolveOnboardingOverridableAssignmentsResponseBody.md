---
title: Get-ImmyResolveOnboardingOverridableAssignmentsResponseBody
---

# Get-ImmyResolveOnboardingOverridableAssignmentsResponseBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetResolveOnboardingOverridableAssignmentsResponseBody` |
| Source | `Cmdlets/GetResolveOnboardingOverridableAssignmentsResponseBody.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/resolve-onboarding-overridable-target-assignments? |
| Return Type | [ResolveOnboardingOverridableAssignmentsResponseBody](../models/ResolveOnboardingOverridableAssignmentsResponseBody.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/resolve-onboarding-overridable-target-assignments?` and deserializes to [ResolveOnboardingOverridableAssignmentsResponseBody](../models/ResolveOnboardingOverridableAssignmentsResponseBody.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ResolveOnboardingOverridableAssignmentsResponseBody](../models/ResolveOnboardingOverridableAssignmentsResponseBody.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
