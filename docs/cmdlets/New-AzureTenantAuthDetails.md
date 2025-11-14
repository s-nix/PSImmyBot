---
title: New-AzureTenantAuthDetails
---

# New-AzureTenantAuthDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureTenantAuthDetails` |
| Source | `Cmdlets/NewAzureTenantAuthDetails.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AzureTenantPrincipalId | `String` | False | — | All | None |
| CustomAppRegAppId | `String` | False | — | All | None |
| CustomAppRegSecret | `String` | False | — | All | None |
| SelectedPermissionLevel | [AzurePermissionLevel2](../models/AzurePermissionLevel2.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
