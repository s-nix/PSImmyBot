---
title: Push-CreateOrUpdateRoleRequest
---

# Push-CreateOrUpdateRoleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushCreateOrUpdateRoleRequest` |
| Source | `Cmdlets/PushCreateOrUpdateRoleRequest.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/roles/{RoleId}? |
| Return Type | `CreateOrUpdateRoleRequest, GetRoleResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/roles/{RoleId}?` and deserializes to `CreateOrUpdateRoleRequest, GetRoleResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateOrUpdateRoleRequest` | True | — | All | None |
| RoleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateOrUpdateRoleRequest, GetRoleResponse` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
