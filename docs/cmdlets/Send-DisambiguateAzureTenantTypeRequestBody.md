---
title: Send-DisambiguateAzureTenantTypeRequestBody
---

# Send-DisambiguateAzureTenantTypeRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDisambiguateAzureTenantTypeRequestBody` |
| Source | `Cmdlets/SendDisambiguateAzureTenantTypeRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/azure/disambiguate-azure-tenant-type? |
| Return Type | [DisambiguateAzureTenantTypeRequestBody](../models/DisambiguateAzureTenantTypeRequestBody.md), [CheckTenantPartnerStatusResponseBody](../models/CheckTenantPartnerStatusResponseBody.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/azure/disambiguate-azure-tenant-type?` and deserializes to [DisambiguateAzureTenantTypeRequestBody](../models/DisambiguateAzureTenantTypeRequestBody.md), [CheckTenantPartnerStatusResponseBody](../models/CheckTenantPartnerStatusResponseBody.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [DisambiguateAzureTenantTypeRequestBody](../models/DisambiguateAzureTenantTypeRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [DisambiguateAzureTenantTypeRequestBody](../models/DisambiguateAzureTenantTypeRequestBody.md), [CheckTenantPartnerStatusResponseBody](../models/CheckTenantPartnerStatusResponseBody.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
