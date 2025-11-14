---
title: New-UserSilencedNotificationResponse
---

# New-UserSilencedNotificationResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUserSilencedNotificationResponse` |
| Source | `Cmdlets/NewUserSilencedNotificationResponse.cs` |
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
| DateSilencedUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| NotificationObjectId | `String` | False | — | All | None |
| NotificationType | [NotificationType](../models/NotificationType.md) | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
