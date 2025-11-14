---
title: Get-TimelineEvent
---

# Get-TimelineEvent

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTimelineEvent` |
| Source | `Cmdlets/GetTimelineEvent.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/events? |
| Return Type | List<[TimelineEvent](../models/TimelineEvent.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/events?` and deserializes to List<[TimelineEvent](../models/TimelineEvent.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| Skip | `Nullable`1` | False | — | All | None |
| Take | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[TimelineEvent](../models/TimelineEvent.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
