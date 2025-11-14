---
title: Get-ProviderTypeDto
---

# Get-ProviderTypeDto

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetProviderTypeDto` |
| Source | `Cmdlets/GetProviderTypeDto.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-types? |
| Return Type | List<[ProviderTypeDto](../models/ProviderTypeDto.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-types?` and deserializes to List<[ProviderTypeDto](../models/ProviderTypeDto.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| IncludeLinkFormSchemas | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ProviderTypeDto](../models/ProviderTypeDto.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
