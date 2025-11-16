---
title: Get-ImmyDynamicProviderTypes
---

# Get-ImmyDynamicProviderTypes

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetDynamicProviderTypes` |
| Source | `Cmdlets/GetDynamicProviderTypes.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/dynamic-provider-types? |
| Return Type | List<[DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/dynamic-provider-types?` and deserializes to List<[DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
