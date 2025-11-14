---
title: Send-GetLatestActionForTenantsRequestBody
---

# Send-GetLatestActionForTenantsRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetLatestActionForTenantsRequestBody` |
| Source | `Cmdlets/SendGetLatestActionForTenantsRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-actions/latest-action-for-tenants? |
| Return Type | `GetLatestActionForTenantsRequestBody, object` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-actions/latest-action-for-tenants?` and deserializes to `GetLatestActionForTenantsRequestBody, object`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `GetLatestActionForTenantsRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetLatestActionForTenantsRequestBody, object` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
