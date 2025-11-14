---
title: Get-LocalMediaResponse
---

# Get-LocalMediaResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalMediaResponse` |
| Source | `Cmdlets/GetLocalMediaResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/media/local/{Id}? |
| Return Type | `LocalMediaResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/media/local/{Id}?` and deserializes to `LocalMediaResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `LocalMediaResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
