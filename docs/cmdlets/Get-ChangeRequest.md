---
title: Get-ChangeRequest
---

# Get-ChangeRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetChangeRequest` |
| Source | `Cmdlets/GetChangeRequest.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/{DeploymentId}/change-requests? |
| Return Type | List<[ChangeRequestResponse](../models/ChangeRequestResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/{DeploymentId}/change-requests?` and deserializes to List<[ChangeRequestResponse](../models/ChangeRequestResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| DeploymentId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ChangeRequestResponse](../models/ChangeRequestResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
