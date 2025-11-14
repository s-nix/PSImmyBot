---
title: New-LocalSoftwareVersion
---

# New-LocalSoftwareVersion

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
| Architecture | `Architecture` | True | — | All | None |
| BlobName | `String` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | `User` | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DependsOnSemanticVersion | `SemanticVersion` | True | — | All | None |
| DeprecatedIdField | `Nullable`1` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| DisplayVersion | `String` | False | — | All | None |
| InstallerFile | `String` | False | — | All | None |
| InstallerType | `SoftwareVersionInstallerType` | True | — | All | None |
| InstallScript | `Script` | True | — | All | None |
| InstallScriptId | `Nullable`1` | False | — | All | None |
| InstallScriptType | `DatabaseType` | True | — | All | None |
| LastResult | `MaintenanceActionResult` | True | — | All | None |
| LicenseType | `LicenseType` | True | — | All | None |
| MaintenanceType | `MaintenanceType` | True | — | All | None |
| Notes | `String` | False | — | All | None |
| NumActionFailures | `Int32` | True | — | All | None |
| NumActionSuccesses | `Int32` | True | — | All | None |
| PackageHash | `String` | False | — | All | None |
| PackageType | `PackageType` | True | — | All | None |
| PostInstallScript | `Script` | True | — | All | None |
| PostInstallScriptId | `Nullable`1` | False | — | All | None |
| PostInstallScriptType | `DatabaseType` | True | — | All | None |
| PostUninstallScript | `Script` | True | — | All | None |
| PostUninstallScriptId | `Nullable`1` | False | — | All | None |
| PostUninstallScriptType | `DatabaseType` | True | — | All | None |
| ProductCode | `String` | False | — | All | None |
| RelativeCacheSourcePath | `String` | False | — | All | None |
| SemanticVersion | `SemanticVersion` | True | — | All | None |
| SemanticVersionString | `String` | False | — | All | None |
| Software | `LocalSoftware` | True | — | All | None |
| SoftwareId | `Int32` | True | — | All | None |
| SoftwareIdentifier | `String` | False | — | All | None |
| SoftwareType | `SoftwareType` | True | — | All | None |
| TestFailedError | `String` | False | — | All | None |
| TestRequired | `Boolean` | True | — | All | None |
| TestScript | `Script` | True | — | All | None |
| TestScriptId | `Nullable`1` | False | — | All | None |
| TestScriptType | `DatabaseType` | True | — | All | None |
| UninstallScript | `Script` | True | — | All | None |
| UninstallScriptId | `Nullable`1` | False | — | All | None |
| UninstallScriptType | `DatabaseType` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | `User` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UpgradeScript | `Script` | True | — | All | None |
| UpgradeScriptId | `Nullable`1` | False | — | All | None |
| UpgradeScriptType | `DatabaseType` | True | — | All | None |
| UpgradeStrategy | `UpdateActionType` | True | — | All | None |
| Url | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
