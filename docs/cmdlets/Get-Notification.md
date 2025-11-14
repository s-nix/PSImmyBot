---
title: Get-Notification
---

# Get-Notification

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetNotification` |
| Source | `Cmdlets/GetNotification.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/notifications/unacknowledged? |
| Return Type | List<[Notification](../models/Notification.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/notifications/unacknowledged?` and deserializes to List<[Notification](../models/Notification.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Limit | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[Notification](../models/Notification.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
