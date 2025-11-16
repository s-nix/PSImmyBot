---
title: New-ImmyGetMaintenanceSessionResponse
---

# New-ImmyGetMaintenanceSessionResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetMaintenanceSessionResponse` |
| Source | `Cmdlets/NewGetMaintenanceSessionResponse.cs` |
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
| Activities | `ICollection`1` | False | — | All | None |
| AgentUpdatesStageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| Computer | [GetComputerResponse](../models/GetComputerResponse.md) | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| ComputerName | `String` | False | — | All | None |
| CreatedBy | `String` | False | — | All | None |
| CreatedById | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| DetectionStageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| Duration | `String` | False | — | All | None |
| ExecutionStageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| FullMaintenance | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| InventoryStageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| JobId | `String` | False | — | All | None |
| Logs | `ICollection`1` | False | — | All | None |
| MaintenanceActions | `ICollection`1` | False | — | All | None |
| Onboarding | `Boolean` | True | — | All | None |
| OnboardingStageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| ResolutionStageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| ScheduledExecutionDate | `Nullable`1` | False | — | All | None |
| ScheduledId | `Nullable`1` | False | — | All | None |
| SessionJobArgs | [SessionJobArgs](../models/SessionJobArgs.md) | True | — | All | None |
| SessionStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| Stages | `ICollection`1` | False | — | All | None |
| Tenant | [GetTenantResponse](../models/GetTenantResponse.md) | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TenantName | `String` | False | — | All | None |
| UpdatedById | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
