---
title: New-ImmyUserSilencedNotification
---

# New-ImmyUserSilencedNotification

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUserSilencedNotification` |
| Source | `Cmdlets/NewUserSilencedNotification.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| NotificationObjectId | `String` | False | — | All | None |
| NotificationType | [NotificationType](../models/NotificationType.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| User | [User](../models/User.md) | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
