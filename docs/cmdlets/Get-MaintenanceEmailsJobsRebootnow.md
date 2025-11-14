---
title: Get-MaintenanceEmailsJobsRebootnow
---

# Get-MaintenanceEmailsJobsRebootnow

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceEmailsJobsRebootnow` |
| Source | `Cmdlets/GetMaintenanceEmailsJobsRebootnow.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-emails/{EmailGuid}/jobs/rebootnow? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-emails/{EmailGuid}/jobs/rebootnow?` and deserializes to `string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| EmailGuid | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `string` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
