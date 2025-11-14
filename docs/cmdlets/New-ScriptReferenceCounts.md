---
title: New-ScriptReferenceCounts
---

# New-ScriptReferenceCounts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewScriptReferenceCounts` |
| Source | `Cmdlets/NewScriptReferenceCounts.cs` |
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
| GlobalMaintenanceTaskCount | `Int32` | True | — | All | None |
| GlobalSoftwareCount | `Int32` | True | — | All | None |
| GlobalSoftwareVersionCount | `Int32` | True | — | All | None |
| LocalMaintenanceTaskCount | `Int32` | True | — | All | None |
| LocalSoftwareCount | `Int32` | True | — | All | None |
| LocalSoftwareVersionCount | `Int32` | True | — | All | None |
| Total | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
