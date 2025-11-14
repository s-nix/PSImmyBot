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
| Return Type | `BulkCreateTenantRequestBody, List<GetTenantResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/bulk-create?` and deserializes to `BulkCreateTenantRequestBody, List<GetTenantResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `BulkCreateTenantRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `BulkCreateTenantRequestBody, List<GetTenantResponse>` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
