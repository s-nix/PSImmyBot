---
title: New-MigrateToSupersedingAssignmentRequest
---

# New-MigrateToSupersedingAssignmentRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMigrateToSupersedingAssignmentRequest` |
| Source | `Cmdlets/NewMigrateToSupersedingAssignmentRequest.cs` |
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
| NewTaskId | `Int32` | True | — | All | None |
| NewTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| OldAssignmentId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
