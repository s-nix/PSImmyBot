---
title: New-ImmyCreateGlobalSoftwareVersionRequestBody
---

# New-ImmyCreateGlobalSoftwareVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCreateGlobalSoftwareVersionRequestBody` |
| Source | `Cmdlets/NewCreateGlobalSoftwareVersionRequestBody.cs` |
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
| BlobName | `String` | False | — | All | None |
| DependsOnSemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| DisplayName | `String` | False | — | All | None |
| DisplayVersion | `String` | False | — | All | None |
| InstallerFile | `String` | False | — | All | None |
| InstallerType | [SoftwareVersionInstallerType](../models/SoftwareVersionInstallerType.md) | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| LicenseType | [LicenseType](../models/LicenseType.md) | True | — | All | None |
| Notes | `String` | False | — | All | None |
| PackageHash | `String` | False | — | All | None |
| PackageType | [PackageType](../models/PackageType.md) | True | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| ProductCode | `String` | False | — | All | None |
| RelativeCacheSourcePath | `String` | False | — | All | None |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareId | `Int32` | True | — | All | None |
| SoftwareIdentifier | `String` | False | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeStrategy | [UpdateActionType](../models/UpdateActionType.md) | True | — | All | None |
| Url | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
