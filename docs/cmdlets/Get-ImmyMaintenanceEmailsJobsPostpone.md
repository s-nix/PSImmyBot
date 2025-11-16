---
title: Get-ImmyMaintenanceEmailsJobsPostpone
---

# Get-ImmyMaintenanceEmailsJobsPostpone

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMaintenanceEmailsJobsPostpone` |
| Source | `Cmdlets/GetMaintenanceEmailsJobsPostpone.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-emails/{EmailGuid}/jobs/postpone? |
| Return Type | `string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-emails/{EmailGuid}/jobs/postpone?` and deserializes to `string`.

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
