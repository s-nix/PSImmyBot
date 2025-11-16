---
title: Send-ImmyLinkClientsToTenantRequestBody
---

# Send-ImmyLinkClientsToTenantRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendLinkClientsToTenantRequestBody` |
| Source | `Cmdlets/SendLinkClientsToTenantRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/clients/link-to-tenant? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/clients/link-to-tenant?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [LinkClientsToTenantRequestBody](../models/LinkClientsToTenantRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
