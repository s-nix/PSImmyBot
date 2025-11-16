---
title: Send-ImmyGetLatestActionForComputersRequestBody
---

# Send-ImmyGetLatestActionForComputersRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetLatestActionForComputersRequestBody` |
| Source | `Cmdlets/SendGetLatestActionForComputersRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-actions/latest-action-for-computers? |
| Return Type | [GetLatestActionForComputersRequestBody](../models/GetLatestActionForComputersRequestBody.md), List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-actions/latest-action-for-computers?` and deserializes to [GetLatestActionForComputersRequestBody](../models/GetLatestActionForComputersRequestBody.md), List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [GetLatestActionForComputersRequestBody](../models/GetLatestActionForComputersRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetLatestActionForComputersRequestBody](../models/GetLatestActionForComputersRequestBody.md), List<[GetMaintenanceActionResponse](../models/GetMaintenanceActionResponse.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
