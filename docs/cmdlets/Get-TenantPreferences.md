---
title: Get-TenantPreferences
---

# Get-TenantPreferences

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTenantPreferences` |
| Source | `Cmdlets/GetTenantPreferences.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/preferences/tenants/{TenantId}? |
| Return Type | `TenantPreferences` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/preferences/tenants/{TenantId}?` and deserializes to `TenantPreferences`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `TenantPreferences` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
