---
title: New-GetComputerResponse
---

# New-GetComputerResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetComputerResponse` |
| Source | `Cmdlets/NewGetComputerResponse.cs` |
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
| Agents | `ICollection`1` | False | — | All | None |
| ComputerName | `String` | False | — | All | None |
| ComputerTagIds | `ICollection`1` | False | — | All | None |
| DetectionOutdated | `Boolean` | True | — | All | None |
| DeviceId | `Guid` | True | — | All | None |
| DevLabVmClaimExpirationDateUtc | `Nullable`1` | False | — | All | None |
| DevLabVmUnclaimed | `Boolean` | True | — | All | None |
| EphemeralAgentConnected | `Boolean` | True | — | All | None |
| ExcludedFromUserAffinity | `Boolean` | True | — | All | None |
| ExcludeFromMaintenance | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Inventory | `Object` | False | — | All | None |
| IsDesktop | `Nullable`1` | False | — | All | None |
| IsDevLab | `Boolean` | True | — | All | None |
| IsDomainController | `Nullable`1` | False | — | All | None |
| IsMissingSomeRequiredInventoryResults | `Nullable`1` | False | — | All | None |
| IsOnline | `Boolean` | True | — | All | None |
| IsPortable | `Nullable`1` | False | — | All | None |
| IsSandbox | `Boolean` | True | — | All | None |
| IsServer | `Nullable`1` | False | — | All | None |
| Licensed | `Boolean` | True | — | All | None |
| Notes | `String` | False | — | All | None |
| OnboardingStatus | `ComputerOnboardingStatus` | True | — | All | None |
| PrimaryPerson | `GetPersonResponse` | True | — | All | None |
| PrimaryPersonId | `Nullable`1` | False | — | All | None |
| Sessions | `ICollection`1` | False | — | All | None |
| Tenant | `GetTenantResponse` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TenantName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
