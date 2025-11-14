---
title: Get-AzureTenantAuthDetails
---

# Get-AzureTenantAuthDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAzureTenantAuthDetails` |
| Source | `Cmdlets/GetAzureTenantAuthDetails.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/auth/get-azure-tenant-auth-details/{AzureTenantPrincipalId}? |
| Return Type | [AzureTenantAuthDetails](../models/AzureTenantAuthDetails.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/auth/get-azure-tenant-auth-details/{AzureTenantPrincipalId}?` and deserializes to [AzureTenantAuthDetails](../models/AzureTenantAuthDetails.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AzureTenantPrincipalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [AzureTenantAuthDetails](../models/AzureTenantAuthDetails.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
