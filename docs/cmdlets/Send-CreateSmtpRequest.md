---
title: Send-CreateSmtpRequest
---

# Send-CreateSmtpRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateSmtpRequest` |
| Source | `Cmdlets/SendCreateSmtpRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/smtp-configs/{TenantId}? |
| Return Type | `CreateSmtpRequest, GetSmtpConfigResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/smtp-configs/{TenantId}?` and deserializes to `CreateSmtpRequest, GetSmtpConfigResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateSmtpRequest` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateSmtpRequest, GetSmtpConfigResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
