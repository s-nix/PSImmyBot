---
title: New-AzureTenantUserSyncResult
---

# New-AzureTenantUserSyncResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureTenantUserSyncResult` |
| Source | `Cmdlets/NewAzureTenantUserSyncResult.cs` |
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
| FailedReason | [AzureError](../models/AzureError.md) | True | — | All | None |
| ImmyTenantsSyncedUsers | `IDictionary`2` | False | — | All | None |
| NumUsersSynced | `Int32` | True | — | All | None |
| PrincipalId | `String` | False | — | All | None |
| WasSuccessful | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
