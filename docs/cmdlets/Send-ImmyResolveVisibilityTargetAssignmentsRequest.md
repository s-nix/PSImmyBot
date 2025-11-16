---
title: Send-ImmyResolveVisibilityTargetAssignmentsRequest
---

# Send-ImmyResolveVisibilityTargetAssignmentsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendResolveVisibilityTargetAssignmentsRequest` |
| Source | `Cmdlets/SendResolveVisibilityTargetAssignmentsRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/visibility? |
| Return Type | [ResolveVisibilityTargetAssignmentsRequest](../models/ResolveVisibilityTargetAssignmentsRequest.md), List<[TargetAssignmentResource](../models/TargetAssignmentResource.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/visibility?` and deserializes to [ResolveVisibilityTargetAssignmentsRequest](../models/ResolveVisibilityTargetAssignmentsRequest.md), List<[TargetAssignmentResource](../models/TargetAssignmentResource.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ResolveVisibilityTargetAssignmentsRequest](../models/ResolveVisibilityTargetAssignmentsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ResolveVisibilityTargetAssignmentsRequest](../models/ResolveVisibilityTargetAssignmentsRequest.md), List<[TargetAssignmentResource](../models/TargetAssignmentResource.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
