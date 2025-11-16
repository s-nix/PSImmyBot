---
title: Remove-ImmySmtpConfigs
---

# Remove-ImmySmtpConfigs

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveSmtpConfigs` |
| Source | `Cmdlets/RemoveSmtpConfigs.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/smtp-configs/{TenantId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/smtp-configs/{TenantId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
