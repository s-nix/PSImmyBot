---
title: Send-ImmyLicensesUpload
---

# Send-ImmyLicensesUpload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendLicensesUpload` |
| Source | `Cmdlets/SendLicensesUpload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/licenses/upload? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/licenses/upload?`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
