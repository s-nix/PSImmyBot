---
title: Remove-ImmyUsersBulkDelete
---

# Remove-ImmyUsersBulkDelete

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveUsersBulkDelete` |
| Source | `Cmdlets/RemoveUsersBulkDelete.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/users/bulk-delete? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/users/bulk-delete?`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| UserIds | `Object` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
