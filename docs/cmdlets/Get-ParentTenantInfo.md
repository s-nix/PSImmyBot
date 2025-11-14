---
title: Get-ParentTenantInfo
---

# Get-ParentTenantInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetParentTenantInfo` |
| Source | `Cmdlets/GetParentTenantInfo.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/parent-tenant-info? |
| Return Type | `ParentTenantInfo` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/parent-tenant-info?` and deserializes to `ParentTenantInfo`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ParentTenantInfo` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
