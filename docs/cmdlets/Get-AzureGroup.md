---
title: Get-AzureGroup
---

# Get-AzureGroup

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAzureGroup` |
| Source | `Cmdlets/GetAzureGroup.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tenants/{ImmyTenantId}/azure-groups/{AzureGroupId}? |
| Return Type | [GetAzureGroupResponse](../models/GetAzureGroupResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tenants/{ImmyTenantId}/azure-groups/{AzureGroupId}?` and deserializes to [GetAzureGroupResponse](../models/GetAzureGroupResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AzureGroupId | `String` | True | — | All | None |
| ImmyTenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetAzureGroupResponse](../models/GetAzureGroupResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
