---
title: Send-ComputersReinventory
---

# Send-ComputersReinventory

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendComputersReinventory` |
| Source | `Cmdlets/SendComputersReinventory.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/{ComputerId}/reinventory? |
| Return Type | [InventoryDeviceCmdResponse](../models/InventoryDeviceCmdResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/reinventory?` and deserializes to [InventoryDeviceCmdResponse](../models/InventoryDeviceCmdResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [InventoryDeviceCmdResponse](../models/InventoryDeviceCmdResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
