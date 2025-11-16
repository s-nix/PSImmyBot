---
title: Get-ImmyGlobalTargetAssignments
---

# Get-ImmyGlobalTargetAssignments

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalTargetAssignments` |
| Source | `Cmdlets/GetGlobalTargetAssignments.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/global? |
| Return Type | List<[GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/global?` and deserializes to List<[GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Filters | `String` | False | — | All | None |
| Page | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| Sorts | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GlobalTargetAssignmentResource](../models/GlobalTargetAssignmentResource.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
