---
title: Get-MaintenanceActionsLatestForTenant
---

# Get-MaintenanceActionsLatestForTenant

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceActionsLatestForTenant` |
| Source | `Cmdlets/GetMaintenanceActionsLatestForTenant.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-actions/latest-for-tenant/{TenantId}? |
| Return Type | `object` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-actions/latest-for-tenant/{TenantId}?` and deserializes to `object`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| CreatedDateUtc | `String` | False | — | All | None |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |
| SessionType | `Nullable`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `object` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
