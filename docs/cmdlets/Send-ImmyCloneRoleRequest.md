---
title: Send-ImmyCloneRoleRequest
---

# Send-ImmyCloneRoleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCloneRoleRequest` |
| Source | `Cmdlets/SendCloneRoleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/roles/{RoleId}/clone? |
| Return Type | [CloneRoleRequest](../models/CloneRoleRequest.md), [GetRoleResponse](../models/GetRoleResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/roles/{RoleId}/clone?` and deserializes to [CloneRoleRequest](../models/CloneRoleRequest.md), [GetRoleResponse](../models/GetRoleResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CloneRoleRequest](../models/CloneRoleRequest.md) | True | — | All | None |
| RoleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CloneRoleRequest](../models/CloneRoleRequest.md), [GetRoleResponse](../models/GetRoleResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
