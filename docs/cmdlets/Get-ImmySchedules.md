---
title: Get-ImmySchedules
---

# Get-ImmySchedules

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSchedules` |
| Source | `Cmdlets/GetSchedules.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/schedules? |
| Return Type | List<[GetScheduleResponse](../models/GetScheduleResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/schedules?` and deserializes to List<[GetScheduleResponse](../models/GetScheduleResponse.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetScheduleResponse](../models/GetScheduleResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
