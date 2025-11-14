---
title: New-Audit
---

# New-Audit

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAudit` |
| Source | `Cmdlets/NewAudit.cs` |
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
| AffectedProperties | `String` | False | — | All | None |
| DateTimeUtc | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Message | `String` | False | — | All | None |
| NewValues | `String` | False | — | All | None |
| ObjectName | `String` | False | — | All | None |
| ObjectType | `String` | False | — | All | None |
| OldValues | `String` | False | — | All | None |
| PrimaryKey | `String` | False | — | All | None |
| Type | `String` | False | — | All | None |
| UserAzureId | `String` | False | — | All | None |
| UserDisplayName | `String` | False | — | All | None |
| UserId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
