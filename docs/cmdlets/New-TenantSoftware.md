---
title: New-TenantSoftware
---

# New-TenantSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTenantSoftware` |
| Source | `Cmdlets/NewTenantSoftware.cs` |
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
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Software | [LocalSoftware](../models/LocalSoftware.md) | True | — | All | None |
| SoftwareId | `Int32` | True | — | All | None |
| Tenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
