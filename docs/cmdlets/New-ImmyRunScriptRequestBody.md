---
title: New-ImmyRunScriptRequestBody
---

# New-ImmyRunScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewRunScriptRequestBody` |
| Source | `Cmdlets/NewRunScriptRequestBody.cs` |
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
| CancellationId | `Guid` | True | — | All | None |
| ComputerId | `Nullable`1` | False | — | All | None |
| MaintenanceActionId | `Nullable`1` | False | — | All | None |
| MaintenanceSessionId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskId | `Nullable`1` | False | — | All | None |
| MaintenanceTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| Script | [Script](../models/Script.md) | True | — | All | None |
| SessionLogId | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TerminalId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
