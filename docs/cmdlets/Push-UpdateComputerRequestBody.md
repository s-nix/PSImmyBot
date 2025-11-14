---
title: Push-UpdateComputerRequestBody
---

# Push-UpdateComputerRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdateComputerRequestBody` |
| Source | `Cmdlets/PushUpdateComputerRequestBody.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/computers/{ComputerId}? |
| Return Type | `UpdateComputerRequestBody, GetComputerResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/computers/{ComputerId}?` and deserializes to `UpdateComputerRequestBody, GetComputerResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | `UpdateComputerRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateComputerRequestBody, GetComputerResponse` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
