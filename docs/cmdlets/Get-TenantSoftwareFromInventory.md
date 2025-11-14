---
title: Get-TenantSoftwareFromInventory
---

# Get-TenantSoftwareFromInventory

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTenantSoftwareFromInventory` |
| Source | `Cmdlets/GetTenantSoftwareFromInventory.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tenants/software-from-inventory/{Id}? |
| Return Type | `List<GetTenantSoftwareFromInventoryResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tenants/software-from-inventory/{Id}?` and deserializes to `List<GetTenantSoftwareFromInventoryResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<GetTenantSoftwareFromInventoryResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
