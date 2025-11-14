---
title: Update-TenantPreferencesOperation
---

# Update-TenantPreferencesOperation

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateTenantPreferencesOperation` |
| Source | `Cmdlets/UpdateTenantPreferencesOperation.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/preferences/tenants/{TenantId}? |
| Return Type | `List<TenantPreferencesOperation>, TenantPreferences` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/preferences/tenants/{TenantId}?` and deserializes to `List<TenantPreferencesOperation>, TenantPreferences`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `List`1` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<TenantPreferencesOperation>, TenantPreferences` records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
