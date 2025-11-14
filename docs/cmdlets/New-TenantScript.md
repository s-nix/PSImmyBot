---
title: New-TenantScript
---

# New-TenantScript

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTenantScript` |
| Source | `Cmdlets/NewTenantScript.cs` |
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
| Relationship | `Relationship` | True | — | All | None |
| Script | `Script` | True | — | All | None |
| ScriptId | `Int32` | True | — | All | None |
| Tenant | `Tenant` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
