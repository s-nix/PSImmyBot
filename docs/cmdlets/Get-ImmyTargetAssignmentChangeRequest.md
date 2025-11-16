---
title: Get-ImmyTargetAssignmentChangeRequest
---

# Get-ImmyTargetAssignmentChangeRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTargetAssignmentChangeRequest` |
| Source | `Cmdlets/GetTargetAssignmentChangeRequest.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/change-request/{ChangeRequestId}? |
| Return Type | [ChangeRequestResponse](../models/ChangeRequestResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/change-request/{ChangeRequestId}?` and deserializes to [ChangeRequestResponse](../models/ChangeRequestResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ChangeRequestId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ChangeRequestResponse](../models/ChangeRequestResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
