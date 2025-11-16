---
title: Get-ImmyTags
---

# Get-ImmyTags

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTags` |
| Source | `Cmdlets/GetTags.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tags/{TagId}? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tags/{TagId}?` and deserializes to `byte[]`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TagId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
