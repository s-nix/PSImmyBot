---
title: New-ImmySemanticVersion
---

# New-ImmySemanticVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewSemanticVersion` |
| Source | `Cmdlets/NewSemanticVersion.cs` |
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
| HasMetadata | `Boolean` | True | — | All | None |
| IsPrerelease | `Boolean` | True | — | All | None |
| Major | `Int32` | True | — | All | None |
| Metadata | `String` | False | — | All | None |
| Minor | `Int32` | True | — | All | None |
| Patch | `Int32` | True | — | All | None |
| Release | `String` | False | — | All | None |
| ReleaseLabels | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
