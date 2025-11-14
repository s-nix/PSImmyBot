---
title: Send-SendTestBrandingEmailRequest
---

# Send-SendTestBrandingEmailRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSendTestBrandingEmailRequest` |
| Source | `Cmdlets/SendSendTestBrandingEmailRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/brandings/send-test-email? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/brandings/send-test-email?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [SendTestBrandingEmailRequest](../models/SendTestBrandingEmailRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
