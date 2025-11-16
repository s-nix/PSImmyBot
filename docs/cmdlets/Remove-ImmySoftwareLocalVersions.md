---
title: Remove-ImmySoftwareLocalVersions
---

# Remove-ImmySoftwareLocalVersions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveSoftwareLocalVersions` |
| Source | `Cmdlets/RemoveSoftwareLocalVersions.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
