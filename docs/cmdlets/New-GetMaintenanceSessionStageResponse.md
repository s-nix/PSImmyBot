---
title: New-GetMaintenanceSessionStageResponse
---

# New-GetMaintenanceSessionStageResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetMaintenanceSessionStageResponse` |
| Source | `Cmdlets/NewGetMaintenanceSessionStageResponse.cs` |
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
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| JobId | `String` | False | — | All | None |
| MaintenanceSession | [GetMaintenanceSessionResponse](../models/GetMaintenanceSessionResponse.md) | True | — | All | None |
| MaintenanceSessionId | `Int32` | True | — | All | None |
| StageStatus | [SessionStatus](../models/SessionStatus.md) | True | — | All | None |
| Type | [SessionStageType](../models/SessionStageType.md) | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
