---
title: New-AnalyzeGlobalSoftwarePackageResponse
---

# New-AnalyzeGlobalSoftwarePackageResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAnalyzeGlobalSoftwarePackageResponse` |
| Source | `Cmdlets/NewAnalyzeGlobalSoftwarePackageResponse.cs` |
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
| BatchInstallScript | `IScriptDetailsBase` | True | — | All | None |
| DefaultPowershellUninstallScript | `IScriptDetailsBase` | True | — | All | None |
| Description | `String` | False | — | All | None |
| DetectionScript | `IScriptDetailsBase` | True | — | All | None |
| DisplayVersion | `String` | False | — | All | None |
| Extension | `String` | False | — | All | None |
| FileName | `String` | False | — | All | None |
| IsExe | `Boolean` | True | — | All | None |
| IsMsi | `Boolean` | True | — | All | None |
| PackageHash | `String` | False | — | All | None |
| PackageType | `PackageType` | True | — | All | None |
| PowerShellInstallScript | `IScriptDetailsBase` | True | — | All | None |
| PowerShellUninstallScript | `IScriptDetailsBase` | True | — | All | None |
| ProductCode | `Nullable`1` | False | — | All | None |
| SoftwareTableName | `String` | False | — | All | None |
| UpgradeCode | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
