---
title: Send-AcknowledgeNotificationsRequest
---

# Send-AcknowledgeNotificationsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendAcknowledgeNotificationsRequest` |
| Source | `Cmdlets/SendAcknowledgeNotificationsRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/notifications/acknowledge? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/notifications/acknowledge?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `AcknowledgeNotificationsRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
