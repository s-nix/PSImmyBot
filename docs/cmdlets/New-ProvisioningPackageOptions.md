---
title: New-ProvisioningPackageOptions
---

# New-ProvisioningPackageOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewProvisioningPackageOptions` |
| Source | `Cmdlets/NewProvisioningPackageOptions.cs` |
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
| DisableHibernation | `Boolean` | True | — | All | None |
| DownloadIso | `Boolean` | True | — | All | None |
| EnableCleanPc | `Boolean` | True | — | All | None |
| EncryptPackage | `Boolean` | True | — | All | None |
| HideAdminAccount | `Boolean` | True | — | All | None |
| LocalAdminPassword | `String` | False | — | All | None |
| LocalAdminUsername | `String` | False | — | All | None |
| PackagePassword | `String` | False | — | All | None |
| SetupAdmin | `Boolean` | True | — | All | None |
| SetupWireless | `Boolean` | True | — | All | None |
| WirelessKey | `String` | False | — | All | None |
| WirelessOpen | `Nullable`1` | False | — | All | None |
| WirelessSsid | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
