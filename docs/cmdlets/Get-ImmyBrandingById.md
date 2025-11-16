---
title: Get-ImmyBrandingById
---

# Get-ImmyBrandingById

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetBrandingById` |
| Source | `Cmdlets/GetBrandingById.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/brandings/{Id}? |
| Return Type | [GetBrandingResponse](../models/GetBrandingResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/brandings/{Id}?` and deserializes to [GetBrandingResponse](../models/GetBrandingResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetBrandingResponse](../models/GetBrandingResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
