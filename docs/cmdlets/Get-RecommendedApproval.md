---
title: Get-RecommendedApproval
---

# Get-RecommendedApproval

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetRecommendedApproval` |
| Source | `Cmdlets/GetRecommendedApproval.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/recommended-approvals? |
| Return Type | List<[GetRecommendedApprovalResponse](../models/GetRecommendedApprovalResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/recommended-approvals?` and deserializes to List<[GetRecommendedApprovalResponse](../models/GetRecommendedApprovalResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[GetRecommendedApprovalResponse](../models/GetRecommendedApprovalResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
