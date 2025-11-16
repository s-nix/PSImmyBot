---
title: New-ImmyAnalyzeLocalSoftwarePackageResponse
---

# New-ImmyAnalyzeLocalSoftwarePackageResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAnalyzeLocalSoftwarePackageResponse` |
| Source | `Cmdlets/NewAnalyzeLocalSoftwarePackageResponse.cs` |
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
| BatchInstallScript | [IScriptDetailsBase](../models/IScriptDetailsBase.md) | True | — | All | None |
| DefaultPowershellUninstallScript | [IScriptDetailsBase](../models/IScriptDetailsBase.md) | True | — | All | None |
| Description | `String` | False | — | All | None |
| DetectionScript | [IScriptDetailsBase](../models/IScriptDetailsBase.md) | True | — | All | None |
| DisplayVersion | `String` | False | — | All | None |
| Extension | `String` | False | — | All | None |
| FileName | `String` | False | — | All | None |
| IsExe | `Boolean` | True | — | All | None |
| IsMsi | `Boolean` | True | — | All | None |
| PackageHash | `String` | False | — | All | None |
| PackageType | [PackageType](../models/PackageType.md) | True | — | All | None |
| PowerShellInstallScript | [IScriptDetailsBase](../models/IScriptDetailsBase.md) | True | — | All | None |
| PowerShellUninstallScript | [IScriptDetailsBase](../models/IScriptDetailsBase.md) | True | — | All | None |
| ProductCode | `Nullable`1` | False | — | All | None |
| SoftwareTableName | `String` | False | — | All | None |
| UpgradeCode | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
