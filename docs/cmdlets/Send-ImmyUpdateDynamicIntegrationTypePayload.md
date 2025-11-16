---
title: Send-ImmyUpdateDynamicIntegrationTypePayload
---

# Send-ImmyUpdateDynamicIntegrationTypePayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateDynamicIntegrationTypePayload` |
| Source | `Cmdlets/SendUpdateDynamicIntegrationTypePayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dynamic-provider-types/local/{Id}? |
| Return Type | [UpdateDynamicIntegrationTypePayload](../models/UpdateDynamicIntegrationTypePayload.md), [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dynamic-provider-types/local/{Id}?` and deserializes to [UpdateDynamicIntegrationTypePayload](../models/UpdateDynamicIntegrationTypePayload.md), [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateDynamicIntegrationTypePayload](../models/UpdateDynamicIntegrationTypePayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateDynamicIntegrationTypePayload](../models/UpdateDynamicIntegrationTypePayload.md), [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
