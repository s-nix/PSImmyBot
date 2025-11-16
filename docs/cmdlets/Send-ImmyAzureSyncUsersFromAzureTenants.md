---
title: Send-ImmyAzureSyncUsersFromAzureTenants
---

# Send-ImmyAzureSyncUsersFromAzureTenants

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendAzureSyncUsersFromAzureTenants` |
| Source | `Cmdlets/SendAzureSyncUsersFromAzureTenants.cs` |
| HTTP Method | Custom |
| Endpoint | /api/v1/azure/sync-users-from-azure-tenants? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [SyncAzureDataForTenantsRequest](../models/SyncAzureDataForTenantsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
