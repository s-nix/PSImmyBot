---
title: Remove-ImmyDynamicProviderTypesTestEnvironment
---

# Remove-ImmyDynamicProviderTypesTestEnvironment

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveDynamicProviderTypesTestEnvironment` |
| Source | `Cmdlets/RemoveDynamicProviderTypesTestEnvironment.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/dynamic-provider-types/test-environment/{TerminalId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/dynamic-provider-types/test-environment/{TerminalId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TerminalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
