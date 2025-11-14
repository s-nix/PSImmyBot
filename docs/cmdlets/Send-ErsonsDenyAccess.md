---
title: Send-ErsonsDenyAccess
---

# Send-ErsonsDenyAccess

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendErsonsDenyAccess` |
| Source | `Cmdlets/SendErsonsDenyAccess.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/persons/{PersonId}/deny-access? |
| Return Type | [CommandResult](../models/CommandResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/persons/{PersonId}/deny-access?` and deserializes to [CommandResult](../models/CommandResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PersonId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CommandResult](../models/CommandResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
