---
title: Update-ImmyApplicationPreferencesOperation
---

# Update-ImmyApplicationPreferencesOperation

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateApplicationPreferencesOperation` |
| Source | `Cmdlets/UpdateApplicationPreferencesOperation.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/preferences/application? |
| Return Type | List<[ApplicationPreferencesOperation](../models/ApplicationPreferencesOperation.md)>, [ApplicationPreferences](../models/ApplicationPreferences.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/preferences/application?` and deserializes to List<[ApplicationPreferencesOperation](../models/ApplicationPreferencesOperation.md)>, [ApplicationPreferences](../models/ApplicationPreferences.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `List`1` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ApplicationPreferencesOperation](../models/ApplicationPreferencesOperation.md)>, [ApplicationPreferences](../models/ApplicationPreferences.md) records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
