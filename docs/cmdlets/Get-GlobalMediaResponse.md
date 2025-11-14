---
title: Get-GlobalMediaResponse
---

# Get-GlobalMediaResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalMediaResponse` |
| Source | `Cmdlets/GetGlobalMediaResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/media/global/{Id}? |
| Return Type | `GlobalMediaResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/media/global/{Id}?` and deserializes to `GlobalMediaResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GlobalMediaResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
