---
title: New-TenantMedia
---

# New-TenantMedia

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTenantMedia` |
| Source | `Cmdlets/NewTenantMedia.cs` |
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
| Media | `Media` | True | — | All | None |
| MediaId | `Int32` | True | — | All | None |
| Relationship | `Relationship` | True | — | All | None |
| Tenant | `Tenant` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
