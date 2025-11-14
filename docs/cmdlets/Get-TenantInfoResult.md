---
title: Get-TenantInfoResult
---

# Get-TenantInfoResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTenantInfoResult` |
| Source | `Cmdlets/GetTenantInfoResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/azure/partner-tenant-infos? |
| Return Type | `List<TenantInfoResult>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/azure/partner-tenant-infos?` and deserializes to `List<TenantInfoResult>`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `List<TenantInfoResult>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
