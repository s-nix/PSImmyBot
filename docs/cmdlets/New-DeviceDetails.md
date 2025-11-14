---
title: New-DeviceDetails
---

# New-DeviceDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDeviceDetails` |
| Source | `Cmdlets/NewDeviceDetails.cs` |
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
| AzureTenantId | `String` | False | — | All | None |
| ChassisTypes | `ICollection`1` | False | — | All | None |
| DeviceId | `Nullable`1` | False | — | All | None |
| DeviceName | `String` | False | — | All | None |
| Domain | `String` | False | — | All | None |
| DomainRole | `Nullable`1` | False | — | All | None |
| IsSandbox | `Boolean` | True | — | All | None |
| MachineId | `String` | False | — | All | None |
| Manufacturer | `String` | False | — | All | None |
| OperatingSystemName | `String` | False | — | All | None |
| OsInstallDateUtc | `Nullable`1` | False | — | All | None |
| SerialNumber | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
