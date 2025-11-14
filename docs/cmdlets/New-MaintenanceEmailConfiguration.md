---
title: New-MaintenanceEmailConfiguration
---

# New-MaintenanceEmailConfiguration

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMaintenanceEmailConfiguration` |
| Source | `Cmdlets/NewMaintenanceEmailConfiguration.cs` |
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
| SendDetectionEmail | `Boolean` | True | — | All | None |
| SendDetectionEmailWhenAllActionsAreCompliant | `Boolean` | True | — | All | None |
| SendFollowUpEmail | `Boolean` | True | — | All | None |
| SendFollowUpOnlyIfActionNeeded | `Boolean` | True | — | All | None |
| ShowMaintenanceActions | `Boolean` | True | — | All | None |
| ShowPostponeButton | `Boolean` | True | — | All | None |
| ShowRunNowButton | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
