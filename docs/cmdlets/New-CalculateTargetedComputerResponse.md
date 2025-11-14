---
title: New-CalculateTargetedComputerResponse
---

# New-CalculateTargetedComputerResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCalculateTargetedComputerResponse` |
| Source | `Cmdlets/NewCalculateTargetedComputerResponse.cs` |
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
| Cn | `String` | False | — | All | None |
| Ct | `ICollection`1` | False | — | All | None |
| Dr | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| Obs | [ComputerOnboardingStatus](../models/ComputerOnboardingStatus.md) | True | — | All | None |
| On | `Boolean` | True | — | All | None |
| Os | `String` | False | — | All | None |
| Ppi | `Nullable`1` | False | — | All | None |
| Ppn | `String` | False | — | All | None |
| Sb | `Boolean` | True | — | All | None |
| Sn | `String` | False | — | All | None |
| Ti | `Int32` | True | — | All | None |
| Tn | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
