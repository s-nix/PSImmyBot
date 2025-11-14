---
title: Send-AddChangeRequestCommentBody
---

# Send-AddChangeRequestCommentBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendAddChangeRequestCommentBody` |
| Source | `Cmdlets/SendAddChangeRequestCommentBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/change-requests/{Id}/comment? |
| Return Type | [AddChangeRequestCommentBody](../models/AddChangeRequestCommentBody.md), [ChangeRequestCommentResponse](../models/ChangeRequestCommentResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/change-requests/{Id}/comment?` and deserializes to [AddChangeRequestCommentBody](../models/AddChangeRequestCommentBody.md), [ChangeRequestCommentResponse](../models/ChangeRequestCommentResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [AddChangeRequestCommentBody](../models/AddChangeRequestCommentBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [AddChangeRequestCommentBody](../models/AddChangeRequestCommentBody.md), [ChangeRequestCommentResponse](../models/ChangeRequestCommentResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
