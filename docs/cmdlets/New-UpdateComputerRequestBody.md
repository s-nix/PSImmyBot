---
title: New-UpdateComputerRequestBody
---

# New-UpdateComputerRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUpdateComputerRequestBody` |
| Source | `Cmdlets/NewUpdateComputerRequestBody.cs` |
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
| AdditionalPersonIds | `ICollection`1` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| OnboardingStatus | [ComputerOnboardingStatus](../models/ComputerOnboardingStatus.md) | True | — | All | None |
| ProviderLinkUpdates | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
