---
title: New-ComputerSearch
---

# New-ComputerSearch

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputerSearch` |
| Source | `Cmdlets/NewComputerSearch.cs` |
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
| ExcludeFromMaintenance | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| Online | `Boolean` | True | — | All | None |
| Tenant | `String` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
