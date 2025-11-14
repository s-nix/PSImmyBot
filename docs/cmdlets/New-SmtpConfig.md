---
title: New-SmtpConfig
---

# New-SmtpConfig

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSmtpConfig` |
| Source | `Cmdlets/NewSmtpConfig.cs` |
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
| Enabled | `Boolean` | True | — | All | None |
| EnableSsl | `Boolean` | True | — | All | None |
| Host | `String` | False | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| PasswordHash | `String` | False | — | All | None |
| Port | `Int32` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| Timeout | `Int32` | True | — | All | None |
| UseAuthentication | `Boolean` | True | — | All | None |
| Username | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
