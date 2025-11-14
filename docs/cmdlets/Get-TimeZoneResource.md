---
title: Get-TimeZoneResource
---

# Get-TimeZoneResource

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTimeZoneResource` |
| Source | `Cmdlets/GetTimeZoneResource.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/system/timezones? |
| Return Type | List<[TimeZoneResource](../models/TimeZoneResource.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/system/timezones?` and deserializes to List<[TimeZoneResource](../models/TimeZoneResource.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[TimeZoneResource](../models/TimeZoneResource.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
