---
title: Send-ImmyChangeTenantsPayload
---

# Send-ImmyChangeTenantsPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendChangeTenantsPayload` |
| Source | `Cmdlets/SendChangeTenantsPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/change-tenant? |
| Return Type | [ChangeTenantsPayload](../models/ChangeTenantsPayload.md), [CommandResult](../models/CommandResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/change-tenant?` and deserializes to [ChangeTenantsPayload](../models/ChangeTenantsPayload.md), [CommandResult](../models/CommandResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ChangeTenantsPayload](../models/ChangeTenantsPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ChangeTenantsPayload](../models/ChangeTenantsPayload.md), [CommandResult](../models/CommandResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
