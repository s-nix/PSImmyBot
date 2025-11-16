---
title: Send-ImmyGrantAccessRequest
---

# Send-ImmyGrantAccessRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGrantAccessRequest` |
| Source | `Cmdlets/SendGrantAccessRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/persons/{PersonId}/grant-access? |
| Return Type | [GrantAccessRequest](../models/GrantAccessRequest.md), [CommandResult](../models/CommandResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/persons/{PersonId}/grant-access?` and deserializes to [GrantAccessRequest](../models/GrantAccessRequest.md), [CommandResult](../models/CommandResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [GrantAccessRequest](../models/GrantAccessRequest.md) | True | — | All | None |
| PersonId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GrantAccessRequest](../models/GrantAccessRequest.md), [CommandResult](../models/CommandResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
