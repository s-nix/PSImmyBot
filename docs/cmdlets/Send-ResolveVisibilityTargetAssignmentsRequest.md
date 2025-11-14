---
title: Send-ResolveVisibilityTargetAssignmentsRequest
---

# Send-ResolveVisibilityTargetAssignmentsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendResolveVisibilityTargetAssignmentsRequest` |
| Source | `Cmdlets/SendResolveVisibilityTargetAssignmentsRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/visibility? |
| Return Type | `ResolveVisibilityTargetAssignmentsRequest, List<TargetAssignmentResource>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/visibility?` and deserializes to `ResolveVisibilityTargetAssignmentsRequest, List<TargetAssignmentResource>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `ResolveVisibilityTargetAssignmentsRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ResolveVisibilityTargetAssignmentsRequest, List<TargetAssignmentResource>` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
