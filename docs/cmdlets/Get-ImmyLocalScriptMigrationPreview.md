---
title: Get-ImmyLocalScriptMigrationPreview
---

# Get-ImmyLocalScriptMigrationPreview

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalScriptMigrationPreview` |
| Source | `Cmdlets/GetLocalScriptMigrationPreview.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/local/{ScriptId}/migrate-local-to-global-what-if? |
| Return Type | [MigrationPreviewResponse](../models/MigrationPreviewResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/local/{ScriptId}/migrate-local-to-global-what-if?` and deserializes to [MigrationPreviewResponse](../models/MigrationPreviewResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ScriptId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [MigrationPreviewResponse](../models/MigrationPreviewResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
