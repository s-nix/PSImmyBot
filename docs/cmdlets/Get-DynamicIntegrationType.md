---
title: Get-DynamicIntegrationType
---

# Get-DynamicIntegrationType

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetDynamicIntegrationType` |
| Source | `Cmdlets/GetDynamicIntegrationType.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/dynamic-provider-types/local/{Id}? |
| Return Type | `DynamicIntegrationTypeResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/dynamic-provider-types/local/{Id}?` and deserializes to `DynamicIntegrationTypeResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `DynamicIntegrationTypeResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
