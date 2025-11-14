---
title: Send-CreateDynamicIntegrationTypePayload
---

# Send-CreateDynamicIntegrationTypePayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateDynamicIntegrationTypePayload` |
| Source | `Cmdlets/SendCreateDynamicIntegrationTypePayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dynamic-provider-types/local;? |
| Return Type | [CreateDynamicIntegrationTypePayload](../models/CreateDynamicIntegrationTypePayload.md), [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dynamic-provider-types/local;?` and deserializes to [CreateDynamicIntegrationTypePayload](../models/CreateDynamicIntegrationTypePayload.md), [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateDynamicIntegrationTypePayload](../models/CreateDynamicIntegrationTypePayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateDynamicIntegrationTypePayload](../models/CreateDynamicIntegrationTypePayload.md), [DynamicIntegrationTypeResponse](../models/DynamicIntegrationTypeResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
