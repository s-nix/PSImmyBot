---
title: Send-ImmyUpdateComputerPrimaryPersonRequestBody
---

# Send-ImmyUpdateComputerPrimaryPersonRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateComputerPrimaryPersonRequestBody` |
| Source | `Cmdlets/SendUpdateComputerPrimaryPersonRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/{ComputerId}/update-primary-person? |
| Return Type | [UpdateComputerPrimaryPersonRequestBody](../models/UpdateComputerPrimaryPersonRequestBody.md), [GetPersonResponse](../models/GetPersonResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/update-primary-person?` and deserializes to [UpdateComputerPrimaryPersonRequestBody](../models/UpdateComputerPrimaryPersonRequestBody.md), [GetPersonResponse](../models/GetPersonResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | [UpdateComputerPrimaryPersonRequestBody](../models/UpdateComputerPrimaryPersonRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateComputerPrimaryPersonRequestBody](../models/UpdateComputerPrimaryPersonRequestBody.md), [GetPersonResponse](../models/GetPersonResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
