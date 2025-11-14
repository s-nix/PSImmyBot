---
title: Send-TestIntegrationMethodRequest
---

# Send-TestIntegrationMethodRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendTestIntegrationMethodRequest` |
| Source | `Cmdlets/SendTestIntegrationMethodRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dynamic-provider-types/test-environment/{TerminalId}/execute-method/{Method}? |
| Return Type | [TestIntegrationMethodRequest](../models/TestIntegrationMethodRequest.md), [ObjectOpResult](../models/ObjectOpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dynamic-provider-types/test-environment/{TerminalId}/execute-method/{Method}?` and deserializes to [TestIntegrationMethodRequest](../models/TestIntegrationMethodRequest.md), [ObjectOpResult](../models/ObjectOpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Method | `String` | True | — | All | None |
| PayloadBody | [TestIntegrationMethodRequest](../models/TestIntegrationMethodRequest.md) | True | — | All | None |
| TerminalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [TestIntegrationMethodRequest](../models/TestIntegrationMethodRequest.md), [ObjectOpResult](../models/ObjectOpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
