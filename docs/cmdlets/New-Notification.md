---
title: New-Notification
---

# New-Notification

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewNotification` |
| Source | `Cmdlets/NewNotification.cs` |
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
| AcknowledgedByUserAzureId | `String` | False | — | All | None |
| AcknowledgedByUserDisplayName | `String` | False | — | All | None |
| AcknowledgedByUserId | `Nullable`1` | False | — | All | None |
| Acknowledgement | `NotificationAcknowledgement` | True | — | All | None |
| AdminOnly | `Boolean` | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Description | `String` | False | — | All | None |
| Id | `Guid` | True | — | All | None |
| InputData | `Object` | False | — | All | None |
| ObjectId | `String` | False | — | All | None |
| OnlyForUserId | `Nullable`1` | False | — | All | None |
| OutputData | `Object` | False | — | All | None |
| Resolved | `Boolean` | True | — | All | None |
| Severity | `NotificationSeverity` | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| Title | `String` | False | — | All | None |
| TriggeredByUserId | `Nullable`1` | False | — | All | None |
| Type | `NotificationType` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
