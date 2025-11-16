---
title: Send-ImmyBulkDeleteRequest
---

# Send-ImmyBulkDeleteRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBulkDeleteRequest` |
| Source | `Cmdlets/SendBulkDeleteRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants/bulk-delete? |
| Return Type | [BulkDeleteRequest](../models/BulkDeleteRequest.md), [DeleteTenantsCmdResponse](../models/DeleteTenantsCmdResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/bulk-delete?` and deserializes to [BulkDeleteRequest](../models/BulkDeleteRequest.md), [DeleteTenantsCmdResponse](../models/DeleteTenantsCmdResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BulkDeleteRequest](../models/BulkDeleteRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [BulkDeleteRequest](../models/BulkDeleteRequest.md), [DeleteTenantsCmdResponse](../models/DeleteTenantsCmdResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
