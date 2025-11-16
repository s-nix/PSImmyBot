---
title: New-ImmySoftwareFileUploadData
---

# New-ImmySoftwareFileUploadData

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSoftwareFileUploadData` |
| Source | `Cmdlets/NewSoftwareFileUploadData.cs` |
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
| FileBlobName | `String` | False | — | All | None |
| InstallerFile | `String` | False | — | All | None |
| InstallerType | [SoftwareVersionInstallerType](../models/SoftwareVersionInstallerType.md) | True | — | All | None |
| Md5Hash | `String` | False | — | All | None |
| PackageType | [PackageType](../models/PackageType.md) | True | — | All | None |
| RelativeCacheSourcePath | `Guid` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
