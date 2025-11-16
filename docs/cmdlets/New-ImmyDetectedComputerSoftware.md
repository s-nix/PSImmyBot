---
title: New-ImmyDetectedComputerSoftware
---

# New-ImmyDetectedComputerSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDetectedComputerSoftware` |
| Source | `Cmdlets/NewDetectedComputerSoftware.cs` |
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
| Computer | [Computer](../models/Computer.md) | True | — | All | None |
| ComputerId | `Int32` | True | — | All | None |
| Context | [SoftwareRegistryContext](../models/SoftwareRegistryContext.md) | True | — | All | None |
| DetectedAt | `DateTimeOffset` | True | — | All | None |
| DisplayIcon | `String` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| DisplayVersion | `String` | False | — | All | None |
| GlobalSoftwareId | `Nullable`1` | False | — | All | None |
| GlobalSoftwareName | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| InstallDate | `Nullable`1` | False | — | All | None |
| InstallLocation | `String` | False | — | All | None |
| OriginalKey | `String` | False | — | All | None |
| Platform | `String` | False | — | All | None |
| PrimaryPerson | [Person](../models/Person.md) | True | — | All | None |
| PrimaryPersonId | `Nullable`1` | False | — | All | None |
| ProductCode | `Nullable`1` | False | — | All | None |
| QuietUninstallString | `String` | False | — | All | None |
| RegistryPath | `String` | False | — | All | None |
| SystemComponent | `Nullable`1` | False | — | All | None |
| Tenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UninstallString | `String` | False | — | All | None |
| UpgradeCode | `Nullable`1` | False | — | All | None |
| UserName | `String` | False | — | All | None |
| UserSid | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
