---
title: Get-AuditLocal
---

# Get-AuditLocal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAuditLocal` |
| Source | `Cmdlets/GetAuditLocal.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/audits/local/dx? |
| Return Type | List<[Audit](../models/Audit.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/audits/local/dx?` and deserializes to List<[Audit](../models/Audit.md)>.
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
