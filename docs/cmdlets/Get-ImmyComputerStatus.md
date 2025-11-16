---
title: Get-ImmyComputerStatus
---

# Get-ImmyComputerStatus

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerStatus` |
| Source | `Cmdlets/GetComputerStatus.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/status? |
| Return Type | `bool` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/status?` and deserializes to `bool`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `bool` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
