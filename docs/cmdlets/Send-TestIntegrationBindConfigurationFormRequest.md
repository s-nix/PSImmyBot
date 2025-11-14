---
title: Send-TestIntegrationBindConfigurationFormRequest
---

# Send-TestIntegrationBindConfigurationFormRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendTestIntegrationBindConfigurationFormRequest` |
| Source | `Cmdlets/SendTestIntegrationBindConfigurationFormRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dynamic-provider-types/test-environment/{TerminalId}/bind-configuration-form? |
| Return Type | [TestIntegrationBindConfigurationFormRequest](../models/TestIntegrationBindConfigurationFormRequest.md), [DynamicFormBindResultOpResult](../models/DynamicFormBindResultOpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dynamic-provider-types/test-environment/{TerminalId}/bind-configuration-form?` and deserializes to [TestIntegrationBindConfigurationFormRequest](../models/TestIntegrationBindConfigurationFormRequest.md), [DynamicFormBindResultOpResult](../models/DynamicFormBindResultOpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [TestIntegrationBindConfigurationFormRequest](../models/TestIntegrationBindConfigurationFormRequest.md) | True | — | All | None |
| TerminalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [TestIntegrationBindConfigurationFormRequest](../models/TestIntegrationBindConfigurationFormRequest.md), [DynamicFormBindResultOpResult](../models/DynamicFormBindResultOpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
