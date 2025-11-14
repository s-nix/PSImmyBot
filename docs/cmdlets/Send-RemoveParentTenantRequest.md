---
title: Send-RemoveParentTenantRequest
---

# Send-RemoveParentTenantRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRemoveParentTenantRequest` |
| Source | `Cmdlets/SendRemoveParentTenantRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants/remove-parent-tenant? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/remove-parent-tenant?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [RemoveParentTenantRequest](../models/RemoveParentTenantRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
