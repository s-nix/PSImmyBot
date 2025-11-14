---
title: Send-NotificationsSilence
---

# Send-NotificationsSilence

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendNotificationsSilence` |
| Source | `Cmdlets/SendNotificationsSilence.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/notifications/{Type}/silence? |
| Return Type | [UserSilencedNotificationResponse](../models/UserSilencedNotificationResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/notifications/{Type}/silence?` and deserializes to [UserSilencedNotificationResponse](../models/UserSilencedNotificationResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ObjectId | `String` | False | — | All | None |
| Type | [NotificationType](../models/NotificationType.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UserSilencedNotificationResponse](../models/UserSilencedNotificationResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
