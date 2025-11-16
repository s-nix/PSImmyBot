---
title: New-ImmyTimelineEvent
---

# New-ImmyTimelineEvent

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTimelineEvent` |
| Source | `Cmdlets/NewTimelineEvent.cs` |
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
| Data | `String` | False | — | All | None |
| DateUtc | `DateTimeOffset` | True | — | All | None |
| EventType | [TimelineEventType](../models/TimelineEventType.md) | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Identifier | `String` | False | — | All | None |
| Message | `String` | False | — | All | None |
| ObjectId | `String` | False | — | All | None |
| ObjectType | [TimelineObjectType](../models/TimelineObjectType.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
