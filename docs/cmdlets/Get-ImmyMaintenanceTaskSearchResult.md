---
title: Get-ImmyMaintenanceTaskSearchResult
---

# Get-ImmyMaintenanceTaskSearchResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceTaskSearchResult` |
| Source | `Cmdlets/GetMaintenanceTaskSearchResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-tasks/search? |
| Return Type | List<[MaintenanceTaskSearchResult](../models/MaintenanceTaskSearchResult.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-tasks/search?` and deserializes to List<[MaintenanceTaskSearchResult](../models/MaintenanceTaskSearchResult.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ConfigurationTaskOnly | `Nullable`1` | False | — | All | None |
| Filters | `String` | False | — | All | None |
| GlobalOnly | `Nullable`1` | False | — | All | None |
| Page | `Nullable`1` | False | — | All | None |
| PageSize | `Nullable`1` | False | — | All | None |
| Sorts | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[MaintenanceTaskSearchResult](../models/MaintenanceTaskSearchResult.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
