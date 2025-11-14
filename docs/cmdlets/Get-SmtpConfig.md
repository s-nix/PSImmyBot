---
title: Get-SmtpConfig
---

# Get-SmtpConfig

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSmtpConfig` |
| Source | `Cmdlets/GetSmtpConfig.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/smtp-configs/{TenantId}? |
| Return Type | `GetSmtpConfigResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/smtp-configs/{TenantId}?` and deserializes to `GetSmtpConfigResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetSmtpConfigResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
