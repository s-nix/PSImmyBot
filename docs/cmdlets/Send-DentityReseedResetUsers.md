---
title: Send-DentityReseedResetUsers
---

# Send-DentityReseedResetUsers

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDentityReseedResetUsers` |
| Source | `Cmdlets/SendDentityReseedResetUsers.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/identity-reseed/ResetUsers? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/identity-reseed/ResetUsers?`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
