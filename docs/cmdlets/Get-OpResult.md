---
title: Get-OpResult
---

# Get-OpResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOpResult` |
| Source | `Cmdlets/GetOpResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/launch-ephemeral-agent? |
| Return Type | `OpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/launch-ephemeral-agent?` and deserializes to `OpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `OpResult` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
