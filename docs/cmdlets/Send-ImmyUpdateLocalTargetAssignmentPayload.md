---
title: Send-ImmyUpdateLocalTargetAssignmentPayload
---

# Send-ImmyUpdateLocalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateLocalTargetAssignmentPayload` |
| Source | `Cmdlets/SendUpdateLocalTargetAssignmentPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/change-request/{ChangeRequestId}? |
| Return Type | [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md), [ChangeRequestResponse](../models/ChangeRequestResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/change-request/{ChangeRequestId}?` and deserializes to [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md), [ChangeRequestResponse](../models/ChangeRequestResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ChangeRequestId | `Int32` | True | — | All | None |
| PayloadBody | [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateLocalTargetAssignmentPayload](../models/UpdateLocalTargetAssignmentPayload.md), [ChangeRequestResponse](../models/ChangeRequestResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
