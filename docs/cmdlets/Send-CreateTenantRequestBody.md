---
title: Send-CreateTenantRequestBody
---

# Send-CreateTenantRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateTenantRequestBody` |
| Source | `Cmdlets/SendCreateTenantRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants? |
| Return Type | `CreateTenantRequestBody, GetTenantResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants?` and deserializes to `CreateTenantRequestBody, GetTenantResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateTenantRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateTenantRequestBody, GetTenantResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
