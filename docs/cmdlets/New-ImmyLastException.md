---
title: New-ImmyLastException
---

# New-ImmyLastException

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewLastException` |
| Source | `Cmdlets/NewLastException.cs` |
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
| Data | `IDictionary`2` | False | — | All | None |
| HelpLink | `String` | False | — | All | None |
| HResult | `Int32` | True | — | All | None |
| InnerException | [LastException](../models/LastException.md) | True | — | All | None |
| Message | `String` | False | — | All | None |
| Source | `String` | False | — | All | None |
| StackTrace | `String` | False | — | All | None |
| TargetSite | [MethodBase](../models/MethodBase.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
