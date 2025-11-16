---
title: Get-ImmyLocalSoftwareVersionBySemanticVersion
---

# Get-ImmyLocalSoftwareVersionBySemanticVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalSoftwareVersionBySemanticVersion` |
| Source | `Cmdlets/GetLocalSoftwareVersionBySemanticVersion.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}? |
| Return Type | [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}?` and deserializes to [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
