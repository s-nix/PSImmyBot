---
title: New-MaintenanceItem
---

# New-MaintenanceItem

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceItem` |
| Source | `Cmdlets/NewMaintenanceItem.cs` |
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
| MaintenanceIdentifier | `String` | False | — | All | None |
| MaintenanceType | [MaintenanceType](../models/MaintenanceType.md) | True | — | All | None |
| ProviderLinkIdForMaintenanceItem | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
