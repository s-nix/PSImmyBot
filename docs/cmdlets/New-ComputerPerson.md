---
title: New-ComputerPerson
---

# New-ComputerPerson

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputerPerson` |
| Source | `Cmdlets/NewComputerPerson.cs` |
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
| Computer | `Computer` | True | — | All | None |
| ComputerId | `Int32` | True | — | All | None |
| Person | `Person` | True | — | All | None |
| PersonId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
