---
title: Get-ImmyGlobalSoftwareVersionBySemanticVersion
---

# Get-ImmyGlobalSoftwareVersionBySemanticVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalSoftwareVersionBySemanticVersion` |
| Source | `Cmdlets/GetGlobalSoftwareVersionBySemanticVersion.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}? |
| Return Type | [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}?` and deserializes to [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
