---
title: Send-GetLatestActionForComputersRequestBody
---

# Send-GetLatestActionForComputersRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetLatestActionForComputersRequestBody` |
| Source | `Cmdlets/SendGetLatestActionForComputersRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-actions/latest-action-for-computers? |
| Return Type | `GetLatestActionForComputersRequestBody, List<GetMaintenanceActionResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-actions/latest-action-for-computers?` and deserializes to `GetLatestActionForComputersRequestBody, List<GetMaintenanceActionResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `GetLatestActionForComputersRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetLatestActionForComputersRequestBody, List<GetMaintenanceActionResponse>` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
