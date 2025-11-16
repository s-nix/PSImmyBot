---
title: Send-ImmySyncAzureDataForTenantsRequest
---

# Send-ImmySyncAzureDataForTenantsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSyncAzureDataForTenantsRequest` |
| Source | `Cmdlets/SendSyncAzureDataForTenantsRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/azure/sync-details-from-azure-tenants? |
| Return Type | [SyncAzureDataForTenantsRequest](../models/SyncAzureDataForTenantsRequest.md), List<[AzureTenantDetailsSyncResult](../models/AzureTenantDetailsSyncResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/azure/sync-details-from-azure-tenants?` and deserializes to [SyncAzureDataForTenantsRequest](../models/SyncAzureDataForTenantsRequest.md), List<[AzureTenantDetailsSyncResult](../models/AzureTenantDetailsSyncResult.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [SyncAzureDataForTenantsRequest](../models/SyncAzureDataForTenantsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [SyncAzureDataForTenantsRequest](../models/SyncAzureDataForTenantsRequest.md), List<[AzureTenantDetailsSyncResult](../models/AzureTenantDetailsSyncResult.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
