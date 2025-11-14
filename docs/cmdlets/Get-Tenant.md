---
title: Get-Tenant
---

# Get-Tenant

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTenant` |
| Source | `Cmdlets/GetTenant.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tenants/{Id}? |
| Return Type | [GetTenantResponse](../models/GetTenantResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tenants/{Id}?` and deserializes to [GetTenantResponse](../models/GetTenantResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetTenantResponse](../models/GetTenantResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
