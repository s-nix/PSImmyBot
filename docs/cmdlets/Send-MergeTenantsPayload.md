---
title: Send-MergeTenantsPayload
---

# Send-MergeTenantsPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMergeTenantsPayload` |
| Source | `Cmdlets/SendMergeTenantsPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants/bulk-merge? |
| Return Type | [MergeTenantsPayload](../models/MergeTenantsPayload.md), [CommandResult](../models/CommandResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/bulk-merge?` and deserializes to [MergeTenantsPayload](../models/MergeTenantsPayload.md), [CommandResult](../models/CommandResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [MergeTenantsPayload](../models/MergeTenantsPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [MergeTenantsPayload](../models/MergeTenantsPayload.md), [CommandResult](../models/CommandResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
