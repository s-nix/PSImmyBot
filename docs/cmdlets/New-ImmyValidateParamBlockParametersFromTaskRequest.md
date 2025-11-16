---
title: New-ImmyValidateParamBlockParametersFromTaskRequest
---

# New-ImmyValidateParamBlockParametersFromTaskRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewValidateParamBlockParametersFromTaskRequest` |
| Source | `Cmdlets/NewValidateParamBlockParametersFromTaskRequest.cs` |
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
| ComputerId | `Nullable`1` | False | — | All | None |
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DeploymentDatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DeploymentId | `Nullable`1` | False | — | All | None |
| ForceRebind | `Boolean` | True | — | All | None |
| MaintenanceSessionId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskId | `Int32` | True | — | All | None |
| ParameterValues | `IDictionary`2` | False | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TerminalId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
