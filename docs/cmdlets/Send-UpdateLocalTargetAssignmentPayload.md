---
title: Send-UpdateLocalTargetAssignmentPayload
---

# Send-UpdateLocalTargetAssignmentPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateLocalTargetAssignmentPayload` |
| Source | `Cmdlets/SendUpdateLocalTargetAssignmentPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/change-request/{ChangeRequestId}? |
| Return Type | `UpdateLocalTargetAssignmentPayload, ChangeRequestResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/change-request/{ChangeRequestId}?` and deserializes to `UpdateLocalTargetAssignmentPayload, ChangeRequestResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ChangeRequestId | `Int32` | True | — | All | None |
| PayloadBody | `UpdateLocalTargetAssignmentPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateLocalTargetAssignmentPayload, ChangeRequestResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
