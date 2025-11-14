---
title: Remove-Users
---

# Remove-Users

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveUsers` |
| Source | `Cmdlets/RemoveUsers.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/users/{UserId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/users/{UserId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
