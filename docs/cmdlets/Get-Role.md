---
title: Get-Role
---

# Get-Role

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetRole` |
| Source | `Cmdlets/GetRole.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/roles/{RoleId}? |
| Return Type | [GetRoleResponse](../models/GetRoleResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/roles/{RoleId}?` and deserializes to [GetRoleResponse](../models/GetRoleResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| RoleId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetRoleResponse](../models/GetRoleResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
