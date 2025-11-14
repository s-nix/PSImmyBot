---
title: New-ComputerListViewModel
---

# New-ComputerListViewModel

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputerListViewModel` |
| Source | `Cmdlets/NewComputerListViewModel.cs` |
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
| ActiveSessionId | `Nullable`1` | False | — | All | None |
| ActiveSessionStatus | `SessionStatus` | True | — | All | None |
| ChassisTypes | `ICollection`1` | False | — | All | None |
| ComputerName | `String` | False | — | All | None |
| ComputerTagIds | `ICollection`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DeletedAt | `Nullable`1` | False | — | All | None |
| DeviceId | `Guid` | True | — | All | None |
| DevLabVmClaimExpirationDateUtc | `Nullable`1` | False | — | All | None |
| DevLabVmName | `String` | False | — | All | None |
| DevLabVmUnclaimed | `Boolean` | True | — | All | None |
| Domain | `String` | False | — | All | None |
| DomainRole | `Nullable`1` | False | — | All | None |
| ExcludeFromMaintenance | `Boolean` | True | — | All | None |
| ExternalIpAddress | `String` | False | — | All | None |
| HasPendingReboot | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| InternalIpAddress | `String` | False | — | All | None |
| IsDevLab | `Boolean` | True | — | All | None |
| IsOnline | `Nullable`1` | False | — | All | None |
| IsSandbox | `Boolean` | True | — | All | None |
| LastBootTimeUtc | `String` | False | — | All | None |
| LastLoggedOnUser | `String` | False | — | All | None |
| LastProviderAgentEventDateUtc | `Nullable`1` | False | — | All | None |
| Licensed | `Nullable`1` | False | — | All | None |
| Manufacturer | `String` | False | — | All | None |
| Model | `String` | False | — | All | None |
| Notes | `String` | False | — | All | None |
| OnboardingStatus | `ComputerOnboardingStatus` | True | — | All | None |
| OperatingSystem | `String` | False | — | All | None |
| PrimaryPersonId | `Nullable`1` | False | — | All | None |
| PrimaryUserEmail | `String` | False | — | All | None |
| PrimaryUserFirstName | `String` | False | — | All | None |
| PrimaryUserLastName | `String` | False | — | All | None |
| ProviderLinkIds | `ICollection`1` | False | — | All | None |
| SerialNumber | `String` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TenantName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
