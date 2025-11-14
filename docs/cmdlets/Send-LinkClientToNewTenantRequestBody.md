---
title: Send-LinkClientToNewTenantRequestBody
---

# Send-LinkClientToNewTenantRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendLinkClientToNewTenantRequestBody` |
| Source | `Cmdlets/SendLinkClientToNewTenantRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/clients/link-to-new-tenant? |
| Return Type | `LinkClientToNewTenantRequestBody, LinkClientToNewTenantResponseBody` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/clients/link-to-new-tenant?` and deserializes to `LinkClientToNewTenantRequestBody, LinkClientToNewTenantResponseBody`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `LinkClientToNewTenantRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `LinkClientToNewTenantRequestBody, LinkClientToNewTenantResponseBody` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
