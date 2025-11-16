---
title: Get-ImmyUserSilencedNotificationResponse
---

# Get-ImmyUserSilencedNotificationResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetUserSilencedNotificationResponse` |
| Source | `Cmdlets/GetUserSilencedNotificationResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/notifications? |
| Return Type | List<[UserSilencedNotificationResponse](../models/UserSilencedNotificationResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/notifications?` and deserializes to List<[UserSilencedNotificationResponse](../models/UserSilencedNotificationResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[UserSilencedNotificationResponse](../models/UserSilencedNotificationResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
