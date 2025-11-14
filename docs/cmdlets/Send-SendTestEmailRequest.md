---
title: Send-SendTestEmailRequest
---

# Send-SendTestEmailRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSendTestEmailRequest` |
| Source | `Cmdlets/SendSendTestEmailRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/smtp-configs/send-test-email? |
| Return Type | [SendTestEmailRequest](../models/SendTestEmailRequest.md), string |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/smtp-configs/send-test-email?` and deserializes to [SendTestEmailRequest](../models/SendTestEmailRequest.md), string.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [SendTestEmailRequest](../models/SendTestEmailRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [SendTestEmailRequest](../models/SendTestEmailRequest.md), string records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
