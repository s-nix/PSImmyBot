---
title: New-MigrationPreviewResponse
---

# New-MigrationPreviewResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMigrationPreviewResponse` |
| Source | `Cmdlets/NewMigrationPreviewResponse.cs` |
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
| MaintenanceTasks | `ICollection`1` | False | — | All | None |
| Scripts | `ICollection`1` | False | — | All | None |
| Software | `ICollection`1` | False | — | All | None |
| SoftwareHasLocalPrerequisites | `Boolean` | True | — | All | None |
| SoftwareVersions | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
