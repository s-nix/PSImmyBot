---
title: Send-ImmyUpdateAzureTenantLinkRequest
---

# Send-ImmyUpdateAzureTenantLinkRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateAzureTenantLinkRequest` |
| Source | `Cmdlets/SendUpdateAzureTenantLinkRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants/update-azure-tenant-link? |
| Return Type | [UpdateAzureTenantLinkRequest](../models/UpdateAzureTenantLinkRequest.md), [GetTenantResponse](../models/GetTenantResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/update-azure-tenant-link?` and deserializes to [UpdateAzureTenantLinkRequest](../models/UpdateAzureTenantLinkRequest.md), [GetTenantResponse](../models/GetTenantResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateAzureTenantLinkRequest](../models/UpdateAzureTenantLinkRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateAzureTenantLinkRequest](../models/UpdateAzureTenantLinkRequest.md), [GetTenantResponse](../models/GetTenantResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
