---
title: New-ImmyTenantTag
---

# New-ImmyTenantTag

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTenantTag` |
| Source | `Cmdlets/NewTenantTag.cs` |
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
| EntityId | `Int32` | True | — | All | None |
| Tag | [Tag](../models/Tag.md) | True | — | All | None |
| TagId | `Int32` | True | — | All | None |
| Tenant | [Tenant](../models/Tenant.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
