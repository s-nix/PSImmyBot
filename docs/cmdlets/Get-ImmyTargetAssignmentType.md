---
title: Get-ImmyTargetAssignmentType
---

# Get-ImmyTargetAssignmentType

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTargetAssignmentType` |
| Source | `Cmdlets/GetTargetAssignmentType.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/{Id}/type? |
| Return Type | [GetTargetAssignmentTypeResponse](../models/GetTargetAssignmentTypeResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/{Id}/type?` and deserializes to [GetTargetAssignmentTypeResponse](../models/GetTargetAssignmentTypeResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetTargetAssignmentTypeResponse](../models/GetTargetAssignmentTypeResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
