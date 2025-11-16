---
title: New-ImmyInventoryTask
---

# New-ImmyInventoryTask

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewInventoryTask` |
| Source | `Cmdlets/NewInventoryTask.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Frequency | [InventoryTaskFrequency](../models/InventoryTaskFrequency.md) | True | — | All | None |
| FrequencyTimespan | `String` | True | — | All | None |
| FromProvider | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| InventoryTaskType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| Scripts | `ICollection`1` | False | — | All | None |
| SpecifiedNumMinutes | `Nullable`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
