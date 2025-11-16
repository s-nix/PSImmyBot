---
title: Get-ImmyTargetAssignmentResource
---

# Get-ImmyTargetAssignmentResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTargetAssignmentResource` |
| Source | `Cmdlets/GetTargetAssignmentResource.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/persons/{Id}/self-service? |
| Return Type | List<[TargetAssignmentResource](../models/TargetAssignmentResource.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/persons/{Id}/self-service?` and deserializes to List<[TargetAssignmentResource](../models/TargetAssignmentResource.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[TargetAssignmentResource](../models/TargetAssignmentResource.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
