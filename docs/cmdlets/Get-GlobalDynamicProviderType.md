---
title: Get-GlobalDynamicProviderType
---

# Get-GlobalDynamicProviderType

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalDynamicProviderType` |
| Source | `Cmdlets/GetGlobalDynamicProviderType.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/dynamic-provider-types/global/{Id}? |
| Return Type | [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/dynamic-provider-types/global/{Id}?` and deserializes to [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
