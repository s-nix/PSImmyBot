---
title: New-ImmyScriptActionAudit
---

# New-ImmyScriptActionAudit

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewScriptActionAudit` |
| Source | `Cmdlets/NewScriptActionAudit.cs` |
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
| DateTimeUtc | `DateTimeOffset` | True | — | All | None |
| NewValue | `String` | False | — | All | None |
| OldValue | `String` | False | — | All | None |
| UserDisplayName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
