---
title: Get-ImmyMaintenanceExcludedComputers
---

# Get-ImmyMaintenanceExcludedComputers

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceExcludedComputers` |
| Source | `Cmdlets/GetMaintenanceExcludedComputers.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tenants/{Id}/computers/excluded-from-maintenance? |
| Return Type | List<[ComputerNameResponse](../models/ComputerNameResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tenants/{Id}/computers/excluded-from-maintenance?` and deserializes to List<[ComputerNameResponse](../models/ComputerNameResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ComputerNameResponse](../models/ComputerNameResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
