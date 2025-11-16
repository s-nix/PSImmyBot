---
title: Get-ImmyPreferences
---

# Get-ImmyPreferences

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetPreferences` |
| Source | `Cmdlets/GetPreferences.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/preferences? |
| Return Type | [GetPreferencesResponse](../models/GetPreferencesResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/preferences?` and deserializes to [GetPreferencesResponse](../models/GetPreferencesResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetPreferencesResponse](../models/GetPreferencesResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
