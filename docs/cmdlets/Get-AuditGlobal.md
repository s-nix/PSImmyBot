---
title: Get-AuditGlobal
---

# Get-AuditGlobal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAuditGlobal` |
| Source | `Cmdlets/GetAuditGlobal.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/audits/global/dx? |
| Return Type | List<[Audit](../models/Audit.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/audits/global/dx?` and deserializes to List<[Audit](../models/Audit.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[Audit](../models/Audit.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
