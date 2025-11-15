---
title: Get-TargetAssignmentChangeRequests
---

# Get-TargetAssignmentChangeRequests

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTargetAssignmentChangeRequests` |
| Source | `Cmdlets/GetTargetAssignmentChangeRequests.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/change-requests? |
| Return Type | List<[ChangeRequestResponse](../models/ChangeRequestResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/change-requests?` and deserializes to List<[ChangeRequestResponse](../models/ChangeRequestResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[ChangeRequestResponse](../models/ChangeRequestResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
