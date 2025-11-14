---
title: Send-DeleteAzureTenantAuthDetailsCmdPayload
---

# Send-DeleteAzureTenantAuthDetailsCmdPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDeleteAzureTenantAuthDetailsCmdPayload` |
| Source | `Cmdlets/SendDeleteAzureTenantAuthDetailsCmdPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/auth/delete-azure-tenant-auth-details? |
| Return Type | [DeleteAzureTenantAuthDetailsCmdPayload](../models/DeleteAzureTenantAuthDetailsCmdPayload.md), [DeleteAzureTenantAuthDetailsCmdResult](../models/DeleteAzureTenantAuthDetailsCmdResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/auth/delete-azure-tenant-auth-details?` and deserializes to [DeleteAzureTenantAuthDetailsCmdPayload](../models/DeleteAzureTenantAuthDetailsCmdPayload.md), [DeleteAzureTenantAuthDetailsCmdResult](../models/DeleteAzureTenantAuthDetailsCmdResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [DeleteAzureTenantAuthDetailsCmdPayload](../models/DeleteAzureTenantAuthDetailsCmdPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [DeleteAzureTenantAuthDetailsCmdPayload](../models/DeleteAzureTenantAuthDetailsCmdPayload.md), [DeleteAzureTenantAuthDetailsCmdResult](../models/DeleteAzureTenantAuthDetailsCmdResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
