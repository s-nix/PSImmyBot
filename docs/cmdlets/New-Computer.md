---
title: New-Computer
---

# New-Computer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputer` |
| Source | `Cmdlets/NewComputer.cs` |
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
| AdditionalPersons | `ICollection`1` | False | — | All | None |
| AgentIdentificationFailures | `ICollection`1` | False | — | All | None |
| Agents | `ICollection`1` | False | — | All | None |
| ChassisTypes | `ICollection`1` | False | — | All | None |
| ComputerName | `String` | False | — | All | None |
| ComputerNote | `ComputerNote` | True | — | All | None |
| ComputerTags | `ICollection`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DeletedAt | `Nullable`1` | False | — | All | None |
| DeletedReason | `String` | False | — | All | None |
| DetectedSoftware | `ICollection`1` | False | — | All | None |
| DetectionOutdated | `Boolean` | True | — | All | None |
| DeviceId | `Guid` | True | — | All | None |
| DevLabVmClaimExpirationDateUtc | `Nullable`1` | False | — | All | None |
| DevLabVmName | `String` | False | — | All | None |
| DevLabVmUnclaimed | `Boolean` | True | — | All | None |
| Domain | `String` | False | — | All | None |
| DomainRole | `Nullable`1` | False | — | All | None |
| ExcludedFromUserAffinity | `Boolean` | True | — | All | None |
| ExcludeFromMaintenance | `Boolean` | True | — | All | None |
| ExternalIpAddress | `String` | False | — | All | None |
| HasPendingReboot | `Nullable`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| InternalIpAddress | `String` | False | — | All | None |
| InventoryStartedDate | `Nullable`1` | False | — | All | None |
| IsSandbox | `Boolean` | True | — | All | None |
| LastBootTimeUtc | `String` | False | — | All | None |
| LastLoggedOnUser | `String` | False | — | All | None |
| LatestInventoryScriptResults | `ICollection`1` | False | — | All | None |
| LatestProviderEvent | `ComputerLatestProviderEvent` | True | — | All | None |
| Manufacturer | `String` | False | — | All | None |
| Model | `String` | False | — | All | None |
| OnboardedDateUtc | `Nullable`1` | False | — | All | None |
| OnboardingStatus | `ComputerOnboardingStatus` | True | — | All | None |
| OperatingSystem | `String` | False | — | All | None |
| OsInstallDate | `Nullable`1` | False | — | All | None |
| OwnerTenant | `Tenant` | True | — | All | None |
| PredecessorComputers | `ICollection`1` | False | — | All | None |
| PrimaryPerson | `Person` | True | — | All | None |
| PrimaryPersonId | `Nullable`1` | False | — | All | None |
| RemoteControlRecordings | `ICollection`1` | False | — | All | None |
| Schedules | `ICollection`1` | False | — | All | None |
| SerialNumber | `String` | False | — | All | None |
| Sessions | `ICollection`1` | False | — | All | None |
| SuccessorComputer | `Computer` | True | — | All | None |
| SuccessorComputerId | `Nullable`1` | False | — | All | None |
| Tags | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UserAffinities | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
