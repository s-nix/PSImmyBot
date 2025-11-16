---
title: Get-ImmyTenantsSoftwareFromInventoryExport
---

# Get-ImmyTenantsSoftwareFromInventoryExport

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTenantsSoftwareFromInventoryExport` |
| Source | `Cmdlets/GetTenantsSoftwareFromInventoryExport.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tenants/software-from-inventory/export? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tenants/software-from-inventory/export?` and deserializes to `byte[]`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
