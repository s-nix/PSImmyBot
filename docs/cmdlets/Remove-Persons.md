---
title: Remove-Persons
---

# Remove-Persons

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemovePersons` |
| Source | `Cmdlets/RemovePersons.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/persons/{Id}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/persons/{Id}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
