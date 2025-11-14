---
title: Send-CreateOrUpdateRoleRequest
---

# Send-CreateOrUpdateRoleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateOrUpdateRoleRequest` |
| Source | `Cmdlets/SendCreateOrUpdateRoleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/roles? |
| Return Type | `CreateOrUpdateRoleRequest, GetRoleResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/roles?` and deserializes to `CreateOrUpdateRoleRequest, GetRoleResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateOrUpdateRoleRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateOrUpdateRoleRequest, GetRoleResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
