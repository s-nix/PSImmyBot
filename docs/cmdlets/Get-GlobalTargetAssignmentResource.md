---
title: Get-GlobalTargetAssignmentResource
---

# Get-GlobalTargetAssignmentResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalTargetAssignmentResource` |
| Source | `Cmdlets/GetGlobalTargetAssignmentResource.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/global/{Id}? |
| Return Type | `GlobalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/global/{Id}?` and deserializes to `GlobalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GlobalTargetAssignmentResource` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
