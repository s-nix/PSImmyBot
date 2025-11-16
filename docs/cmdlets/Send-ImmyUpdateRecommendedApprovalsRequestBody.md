---
title: Send-ImmyUpdateRecommendedApprovalsRequestBody
---

# Send-ImmyUpdateRecommendedApprovalsRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateRecommendedApprovalsRequestBody` |
| Source | `Cmdlets/SendUpdateRecommendedApprovalsRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/recommended-approvals/update? |
| Return Type | [UpdateRecommendedApprovalsRequestBody](../models/UpdateRecommendedApprovalsRequestBody.md), List<[GetRecommendedApprovalResponse](../models/GetRecommendedApprovalResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/recommended-approvals/update?` and deserializes to [UpdateRecommendedApprovalsRequestBody](../models/UpdateRecommendedApprovalsRequestBody.md), List<[GetRecommendedApprovalResponse](../models/GetRecommendedApprovalResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateRecommendedApprovalsRequestBody](../models/UpdateRecommendedApprovalsRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateRecommendedApprovalsRequestBody](../models/UpdateRecommendedApprovalsRequestBody.md), List<[GetRecommendedApprovalResponse](../models/GetRecommendedApprovalResponse.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
