---
title: Send-CloneRoleRequest
---

# Send-CloneRoleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCloneRoleRequest` |
| Source | `Cmdlets/SendCloneRoleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/roles/{RoleId}/clone? |
| Return Type | `CloneRoleRequest, GetRoleResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/roles/{RoleId}/clone?` and deserializes to `CloneRoleRequest, GetRoleResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CloneRoleRequest` | True | — | All | None |
| RoleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CloneRoleRequest, GetRoleResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
