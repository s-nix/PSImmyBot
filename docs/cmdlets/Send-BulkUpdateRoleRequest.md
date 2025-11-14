---
title: Send-BulkUpdateRoleRequest
---

# Send-BulkUpdateRoleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBulkUpdateRoleRequest` |
| Source | `Cmdlets/SendBulkUpdateRoleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/add-roles? |
| Return Type | `BulkUpdateRoleRequest, string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/add-roles?` and deserializes to `BulkUpdateRoleRequest, string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `BulkUpdateRoleRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `BulkUpdateRoleRequest, string` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
