---
title: New-ComputerInventoryAllSoftware
---

# New-ComputerInventoryAllSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputerInventoryAllSoftware` |
| Source | `Cmdlets/NewComputerInventoryAllSoftware.cs` |
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
| Computer | `String` | False | — | All | None |
| ComputerId | `Int32` | True | — | All | None |
| SoftwareName | `String` | False | — | All | None |
| SoftwareVersion | `String` | False | — | All | None |
| Tenant | `String` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
