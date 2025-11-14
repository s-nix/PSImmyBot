---
title: Send-UpdateRecommendedApprovalsRequestBody
---

# Send-UpdateRecommendedApprovalsRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateRecommendedApprovalsRequestBody` |
| Source | `Cmdlets/SendUpdateRecommendedApprovalsRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/recommended-approvals/update? |
| Return Type | `UpdateRecommendedApprovalsRequestBody, List<GetRecommendedApprovalResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/recommended-approvals/update?` and deserializes to `UpdateRecommendedApprovalsRequestBody, List<GetRecommendedApprovalResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `UpdateRecommendedApprovalsRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateRecommendedApprovalsRequestBody, List<GetRecommendedApprovalResponse>` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
