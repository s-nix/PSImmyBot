---
title: Update-ImmyTenantsActivate
---

# Update-ImmyTenantsActivate

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateTenantsActivate` |
| Source | `Cmdlets/UpdateTenantsActivate.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/tenants/activate/{Id}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/tenants/activate/{Id}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
