---
title: Get-MaintenanceActionsByVersion
---

# Get-MaintenanceActionsByVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceActionsByVersion` |
| Source | `Cmdlets/GetMaintenanceActionsByVersion.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-actions/version? |
| Return Type | List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-actions/version?` and deserializes to List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `String` | True | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| Version | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
