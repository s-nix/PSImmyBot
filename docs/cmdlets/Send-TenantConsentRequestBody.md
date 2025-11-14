---
title: Send-TenantConsentRequestBody
---

# Send-TenantConsentRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendTenantConsentRequestBody` |
| Source | `Cmdlets/SendTenantConsentRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/azure/tenant-consented? |
| Return Type | [TenantConsentRequestBody](../models/TenantConsentRequestBody.md), [TenantConsentResponseBody](../models/TenantConsentResponseBody.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/azure/tenant-consented?` and deserializes to [TenantConsentRequestBody](../models/TenantConsentRequestBody.md), [TenantConsentResponseBody](../models/TenantConsentResponseBody.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [TenantConsentRequestBody](../models/TenantConsentRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [TenantConsentRequestBody](../models/TenantConsentRequestBody.md), [TenantConsentResponseBody](../models/TenantConsentResponseBody.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
