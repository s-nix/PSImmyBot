---
title: Send-UpdateAzureTenantAuthDetailsCmdPayload
---

# Send-UpdateAzureTenantAuthDetailsCmdPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateAzureTenantAuthDetailsCmdPayload` |
| Source | `Cmdlets/SendUpdateAzureTenantAuthDetailsCmdPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/auth/update-azure-tenant-auth-details? |
| Return Type | `UpdateAzureTenantAuthDetailsCmdPayload, UpdateAzureTenantAuthDetailsCmdResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/auth/update-azure-tenant-auth-details?` and deserializes to `UpdateAzureTenantAuthDetailsCmdPayload, UpdateAzureTenantAuthDetailsCmdResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `UpdateAzureTenantAuthDetailsCmdPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateAzureTenantAuthDetailsCmdPayload, UpdateAzureTenantAuthDetailsCmdResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
