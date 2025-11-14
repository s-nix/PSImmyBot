---
title: Get-LocalTargetAssignmentResource
---

# Get-LocalTargetAssignmentResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalTargetAssignmentResource` |
| Source | `Cmdlets/GetLocalTargetAssignmentResource.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/{Id}? |
| Return Type | `LocalTargetAssignmentResource` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/{Id}?` and deserializes to `LocalTargetAssignmentResource`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `LocalTargetAssignmentResource` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
