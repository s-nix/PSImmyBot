---
title: New-ImmyGetSoftwarePrerequisiteResponse
---

# New-ImmyGetSoftwarePrerequisiteResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetSoftwarePrerequisiteResponse` |
| Source | `Cmdlets/NewGetSoftwarePrerequisiteResponse.cs` |
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
| ActionToPerform | [ActionToPerform](../models/ActionToPerform.md) | True | — | All | None |
| Condition | [Condition](../models/Condition.md) | True | — | All | None |
| SoftwaresForCondition | `ICollection`1` | False | — | All | None |
| SoftwaresToPerformActionOn | `ICollection`1` | False | — | All | None |
| SubjectQualifier | [SubjectQualifier](../models/SubjectQualifier.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
