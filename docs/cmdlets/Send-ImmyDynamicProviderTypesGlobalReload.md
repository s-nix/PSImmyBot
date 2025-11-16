---
title: Send-ImmyDynamicProviderTypesGlobalReload
---

# Send-ImmyDynamicProviderTypesGlobalReload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDynamicProviderTypesGlobalReload` |
| Source | `Cmdlets/SendDynamicProviderTypesGlobalReload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dynamic-provider-types/global/{Id}/reload? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dynamic-provider-types/global/{Id}/reload?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
