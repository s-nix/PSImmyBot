---
title: Push-ImmyUpdateComputerRequestBody
---

# Push-ImmyUpdateComputerRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateComputerRequestBody` |
| Source | `Cmdlets/PushUpdateComputerRequestBody.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/computers/{ComputerId}? |
| Return Type | [UpdateComputerRequestBody](../models/UpdateComputerRequestBody.md), [GetComputerResponse](../models/GetComputerResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/computers/{ComputerId}?` and deserializes to [UpdateComputerRequestBody](../models/UpdateComputerRequestBody.md), [GetComputerResponse](../models/GetComputerResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | [UpdateComputerRequestBody](../models/UpdateComputerRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateComputerRequestBody](../models/UpdateComputerRequestBody.md), [GetComputerResponse](../models/GetComputerResponse.md) records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
