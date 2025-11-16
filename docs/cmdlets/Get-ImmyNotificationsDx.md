---
title: Get-ImmyNotificationsDx
---

# Get-ImmyNotificationsDx

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetNotificationsDx` |
| Source | `Cmdlets/GetNotificationsDx.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/notifications/dx? |
| Return Type | List<[Notification](../models/Notification.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/notifications/dx?` and deserializes to List<[Notification](../models/Notification.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[Notification](../models/Notification.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
