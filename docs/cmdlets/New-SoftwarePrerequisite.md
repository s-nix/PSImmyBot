---
title: New-SoftwarePrerequisite
---

# New-SoftwarePrerequisite

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSoftwarePrerequisite` |
| Source | `Cmdlets/NewSoftwarePrerequisite.cs` |
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
| ActionToPerform | `ActionToPerform` | True | — | All | None |
| Condition | `Condition` | True | — | All | None |
| SoftwaresForCondition | `ICollection`1` | False | — | All | None |
| SoftwareSpecifiers | `ICollection`1` | False | — | All | None |
| SoftwaresToPerformActionOn | `ICollection`1` | False | — | All | None |
| SubjectQualifier | `SubjectQualifier` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
