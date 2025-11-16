---
title: Get-ImmyWebhooks
---

# Get-ImmyWebhooks

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetWebhooks` |
| Source | `Cmdlets/GetWebhooks.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/webhooks/{Id}? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/webhooks/{Id}?` and deserializes to `byte[]`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
