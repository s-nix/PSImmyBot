---
title: Get-ProviderClient
---

# Get-ProviderClient

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetProviderClient` |
| Source | `Cmdlets/GetProviderClient.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-links/{Id}/clients? |
| Return Type | List<[GetProviderClientResponse](../models/GetProviderClientResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-links/{Id}/clients?` and deserializes to List<[GetProviderClientResponse](../models/GetProviderClientResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetProviderClientResponse](../models/GetProviderClientResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
