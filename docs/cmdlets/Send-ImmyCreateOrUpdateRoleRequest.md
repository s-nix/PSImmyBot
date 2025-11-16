---
title: Send-ImmyCreateOrUpdateRoleRequest
---

# Send-ImmyCreateOrUpdateRoleRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateOrUpdateRoleRequest` |
| Source | `Cmdlets/SendCreateOrUpdateRoleRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/roles? |
| Return Type | [CreateOrUpdateRoleRequest](../models/CreateOrUpdateRoleRequest.md), [GetRoleResponse](../models/GetRoleResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/roles?` and deserializes to [CreateOrUpdateRoleRequest](../models/CreateOrUpdateRoleRequest.md), [GetRoleResponse](../models/GetRoleResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateOrUpdateRoleRequest](../models/CreateOrUpdateRoleRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateOrUpdateRoleRequest](../models/CreateOrUpdateRoleRequest.md), [GetRoleResponse](../models/GetRoleResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
