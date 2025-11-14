---
title: Get-MigrationPreviewResponse
---

# Get-MigrationPreviewResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMigrationPreviewResponse` |
| Source | `Cmdlets/GetMigrationPreviewResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/migrate-local-to-global-what-if? |
| Return Type | `MigrationPreviewResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/local/{SoftwareIdentifier}/migrate-local-to-global-what-if?` and deserializes to `MigrationPreviewResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `MigrationPreviewResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
