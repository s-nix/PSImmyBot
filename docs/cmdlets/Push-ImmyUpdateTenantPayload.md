---
title: Push-ImmyUpdateTenantPayload
---

# Push-ImmyUpdateTenantPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateTenantPayload` |
| Source | `Cmdlets/PushUpdateTenantPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/tenants/{Id}? |
| Return Type | [UpdateTenantPayload](../models/UpdateTenantPayload.md), [GetTenantResponse](../models/GetTenantResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/tenants/{Id}?` and deserializes to [UpdateTenantPayload](../models/UpdateTenantPayload.md), [GetTenantResponse](../models/GetTenantResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateTenantPayload](../models/UpdateTenantPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateTenantPayload](../models/UpdateTenantPayload.md), [GetTenantResponse](../models/GetTenantResponse.md) records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
