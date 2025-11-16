---
title: New-ImmyLocalSoftwareVersion
---

# New-ImmyLocalSoftwareVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewLocalSoftwareVersion` |
| Source | `Cmdlets/NewLocalSoftwareVersion.cs` |
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
| Architecture | [Architecture](../models/Architecture.md) | True | — | All | None |
| BlobName | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DependsOnSemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| DeprecatedIdField | `Nullable`1` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| DisplayVersion | `String` | False | — | All | None |
| InstallerFile | `String` | False | — | All | None |
| InstallerType | [SoftwareVersionInstallerType](../models/SoftwareVersionInstallerType.md) | True | — | All | None |
| InstallScript | [Script](../models/Script.md) | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| InstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| LastResult | [MaintenanceActionResult](../models/MaintenanceActionResult.md) | True | — | All | None |
| LicenseType | [LicenseType](../models/LicenseType.md) | True | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| Notes | `String` | False | — | All | None |
| NumActionFailures | `Int32` | True | — | All | None |
| NumActionSuccesses | `Int32` | True | — | All | None |
| PackageHash | `String` | False | — | All | None |
| PackageType | [PackageType](../models/PackageType.md) | True | — | All | None |
| PostInstallScript | [Script](../models/Script.md) | True | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostInstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| PostUninstallScript | [Script](../models/Script.md) | True | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| ProductCode | `String` | False | — | All | None |
| RelativeCacheSourcePath | `String` | False | — | All | None |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SemanticVersionString | `String` | False | — | All | None |
| Software | [LocalSoftware](../models/LocalSoftware.md) | True | — | All | None |
| SoftwareId | `Int32` | True | — | All | None |
| SoftwareIdentifier | `String` | False | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScript | [Script](../models/Script.md) | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UninstallScript | [Script](../models/Script.md) | True | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UpgradeScript | [Script](../models/Script.md) | True | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| UpgradeStrategy | [UpdateActionType](../models/UpdateActionType.md) | True | — | All | None |
| Url | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
