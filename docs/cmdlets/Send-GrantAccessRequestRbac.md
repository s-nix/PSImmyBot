---
title: Send-GrantAccessRequestRbac
---

# Send-GrantAccessRequestRbac

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGrantAccessRequestRbac` |
| Source | `Cmdlets/SendGrantAccessRequestRbac.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/grant-access? |
| Return Type | [GrantAccessRequestRbac](../models/GrantAccessRequestRbac.md), [CommandResult](../models/CommandResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/grant-access?` and deserializes to [GrantAccessRequestRbac](../models/GrantAccessRequestRbac.md), [CommandResult](../models/CommandResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [GrantAccessRequestRbac](../models/GrantAccessRequestRbac.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GrantAccessRequestRbac](../models/GrantAccessRequestRbac.md), [CommandResult](../models/CommandResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
