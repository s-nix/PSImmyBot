---
title: New-MaintenanceSession
---

# New-MaintenanceSession

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceSession` |
| Source | `Cmdlets/NewMaintenanceSession.cs` |
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
| ActiveSession | [ActiveSession](../models/ActiveSession.md) | True | — | All | None |
| Activities | `ICollection`1` | False | — | All | None |
| Computer | [Computer](../models/Computer.md) | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Duration | `String` | False | — | All | None |
| FullMaintenance | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| JobArgs | [SessionJobArgs](../models/SessionJobArgs.md) | True | — | All | None |
| JobId | `String` | False | — | All | None |
| Logs | `ICollection`1` | False | — | All | None |
| MaintenanceActions | `ICollection`1` | False | — | All | None |
| Onboarding | `Boolean` | True | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| Person | [Person](../models/Person.md) | True | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| Phases | `ICollection`1` | False | — | All | None |
| ScheduledExecutionDate | `Nullable`1` | False | — | All | None |
| ScheduledId | `Nullable`1` | False | — | All | None |
| SessionStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| Stages | `ICollection`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UsingActiveHours | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
