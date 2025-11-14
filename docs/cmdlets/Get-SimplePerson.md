---
title: Get-SimplePerson
---

# Get-SimplePerson

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSimplePerson` |
| Source | `Cmdlets/GetSimplePerson.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/persons/{Id}? |
| Return Type | `GetSimplePersonResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/persons/{Id}?` and deserializes to `GetSimplePersonResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetSimplePersonResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
