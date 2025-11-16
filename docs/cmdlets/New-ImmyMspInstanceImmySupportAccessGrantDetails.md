---
title: New-ImmyMspInstanceImmySupportAccessGrantDetails
---

# New-ImmyMspInstanceImmySupportAccessGrantDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMspInstanceImmySupportAccessGrantDetails` |
| Source | `Cmdlets/NewMspInstanceImmySupportAccessGrantDetails.cs` |
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
| DisabledByEmail | `String` | False | — | All | None |
| DisabledByName | `String` | False | — | All | None |
| DisabledDateUtc | `Nullable`1` | False | — | All | None |
| EnabledByEmail | `String` | False | — | All | None |
| EnabledByName | `String` | False | — | All | None |
| EnabledDateUtc | `DateTimeOffset` | True | — | All | None |
| IsEnabled | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
