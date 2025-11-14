---
title: Send-BulkCreateTenantRequestBody
---

# Send-BulkCreateTenantRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBulkCreateTenantRequestBody` |
| Source | `Cmdlets/SendBulkCreateTenantRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants/bulk-create? |
| Return Type | [BulkCreateTenantRequestBody](../models/BulkCreateTenantRequestBody.md), List<[GetTenantResponse](../models/GetTenantResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/bulk-create?` and deserializes to [BulkCreateTenantRequestBody](../models/BulkCreateTenantRequestBody.md), List<[GetTenantResponse](../models/GetTenantResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BulkCreateTenantRequestBody](../models/BulkCreateTenantRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [BulkCreateTenantRequestBody](../models/BulkCreateTenantRequestBody.md), List<[GetTenantResponse](../models/GetTenantResponse.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
