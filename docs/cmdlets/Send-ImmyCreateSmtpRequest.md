---
title: Send-ImmyCreateSmtpRequest
---

# Send-ImmyCreateSmtpRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateSmtpRequest` |
| Source | `Cmdlets/SendCreateSmtpRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/smtp-configs/{TenantId}? |
| Return Type | [CreateSmtpRequest](../models/CreateSmtpRequest.md), [GetSmtpConfigResponse](../models/GetSmtpConfigResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/smtp-configs/{TenantId}?` and deserializes to [CreateSmtpRequest](../models/CreateSmtpRequest.md), [GetSmtpConfigResponse](../models/GetSmtpConfigResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateSmtpRequest](../models/CreateSmtpRequest.md) | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateSmtpRequest](../models/CreateSmtpRequest.md), [GetSmtpConfigResponse](../models/GetSmtpConfigResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
