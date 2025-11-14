---
title: Remove-Tags
---

# Remove-Tags

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveTags` |
| Source | `Cmdlets/RemoveTags.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/tags/{TagId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/tags/{TagId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TagId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
