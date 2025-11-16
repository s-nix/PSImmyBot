---
title: Send-ImmyLinkClientToNewTenantRequestBody
---

# Send-ImmyLinkClientToNewTenantRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendLinkClientToNewTenantRequestBody` |
| Source | `Cmdlets/SendLinkClientToNewTenantRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/clients/link-to-new-tenant? |
| Return Type | [LinkClientToNewTenantRequestBody](../models/LinkClientToNewTenantRequestBody.md), [LinkClientToNewTenantResponseBody](../models/LinkClientToNewTenantResponseBody.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/clients/link-to-new-tenant?` and deserializes to [LinkClientToNewTenantRequestBody](../models/LinkClientToNewTenantRequestBody.md), [LinkClientToNewTenantResponseBody](../models/LinkClientToNewTenantResponseBody.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [LinkClientToNewTenantRequestBody](../models/LinkClientToNewTenantRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [LinkClientToNewTenantRequestBody](../models/LinkClientToNewTenantRequestBody.md), [LinkClientToNewTenantResponseBody](../models/LinkClientToNewTenantResponseBody.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
