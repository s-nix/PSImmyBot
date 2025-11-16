---
title: New-ImmyDetectedComputerSoftwareResponse
---

# New-ImmyDetectedComputerSoftwareResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDetectedComputerSoftwareResponse` |
| Source | `Cmdlets/NewDetectedComputerSoftwareResponse.cs` |
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
| ComputerId | `Int32` | True | — | All | None |
| ComputerName | `String` | False | — | All | None |
| DetectedAt | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| InstallDate | `Nullable`1` | False | — | All | None |
| InstallLocation | `String` | False | — | All | None |
| PersonEmail | `String` | False | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| PersonName | `String` | False | — | All | None |
| Platform | `String` | False | — | All | None |
| ProductCode | `Nullable`1` | False | — | All | None |
| QuietUninstallString | `String` | False | — | All | None |
| RegistryPath | `String` | False | — | All | None |
| SoftwareId | `Nullable`1` | False | — | All | None |
| SoftwareName | `String` | False | — | All | None |
| SystemComponent | `Nullable`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TenantName | `String` | False | — | All | None |
| UninstallString | `String` | False | — | All | None |
| UpgradeCode | `Nullable`1` | False | — | All | None |
| Version | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
