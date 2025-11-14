---
title: Send-SetupTestIntegrationRequest
---

# Send-SetupTestIntegrationRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSetupTestIntegrationRequest` |
| Source | `Cmdlets/SendSetupTestIntegrationRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dynamic-provider-types/test-environment/{TerminalId}? |
| Return Type | `SetupTestIntegrationRequest, DynamicFormBindResultOpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dynamic-provider-types/test-environment/{TerminalId}?` and deserializes to `SetupTestIntegrationRequest, DynamicFormBindResultOpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `SetupTestIntegrationRequest` | True | — | All | None |
| TerminalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `SetupTestIntegrationRequest, DynamicFormBindResultOpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
