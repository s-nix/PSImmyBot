---
title: Get-ImmyLocalMediaResponse
---

# Get-ImmyLocalMediaResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalMediaResponse` |
| Source | `Cmdlets/GetLocalMediaResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/media/local/{Id}? |
| Return Type | [LocalMediaResponse](../models/LocalMediaResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/media/local/{Id}?` and deserializes to [LocalMediaResponse](../models/LocalMediaResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [LocalMediaResponse](../models/LocalMediaResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
