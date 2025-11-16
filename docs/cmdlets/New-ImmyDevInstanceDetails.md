---
title: New-ImmyDevInstanceDetails
---

# New-ImmyDevInstanceDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDevInstanceDetails` |
| Source | `Cmdlets/NewDevInstanceDetails.cs` |
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
| BackendVersion | `String` | False | — | All | None |
| IsHangfireServerRunning | `Boolean` | True | — | All | None |
| PostRoutes | `IDictionary`2` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
