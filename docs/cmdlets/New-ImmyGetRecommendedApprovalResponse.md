---
title: New-ImmyGetRecommendedApprovalResponse
---

# New-ImmyGetRecommendedApprovalResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetRecommendedApprovalResponse` |
| Source | `Cmdlets/NewGetRecommendedApprovalResponse.cs` |
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
| Approved | `Boolean` | True | — | All | None |
| CreatedBy | `String` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| GlobalTargetAssignmentId | `Int32` | True | — | All | None |
| UpdatedBy | `String` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
