---
title: Update-UserPreferencesOperation
---

# Update-UserPreferencesOperation

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateUserPreferencesOperation` |
| Source | `Cmdlets/UpdateUserPreferencesOperation.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/preferences/my? |
| Return Type | `List<UserPreferencesOperation>, UserPreferences` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/preferences/my?` and deserializes to `List<UserPreferencesOperation>, UserPreferences`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `List`1` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<UserPreferencesOperation>, UserPreferences` records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
