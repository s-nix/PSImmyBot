---
title: Send-IntegrationBindParametersRequest
---

# Send-IntegrationBindParametersRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendIntegrationBindParametersRequest` |
| Source | `Cmdlets/SendIntegrationBindParametersRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-types/{ProviderType}/bind-parameters? |
| Return Type | [IntegrationBindParametersRequest](../models/IntegrationBindParametersRequest.md), [DynamicFormBindResult](../models/DynamicFormBindResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-types/{ProviderType}/bind-parameters?` and deserializes to [IntegrationBindParametersRequest](../models/IntegrationBindParametersRequest.md), [DynamicFormBindResult](../models/DynamicFormBindResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [IntegrationBindParametersRequest](../models/IntegrationBindParametersRequest.md) | True | — | All | None |
| ProviderType | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [IntegrationBindParametersRequest](../models/IntegrationBindParametersRequest.md), [DynamicFormBindResult](../models/DynamicFormBindResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
