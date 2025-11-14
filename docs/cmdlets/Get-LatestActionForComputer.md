---
title: Get-LatestActionForComputer
---

# Get-LatestActionForComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLatestActionForComputer` |
| Source | `Cmdlets/GetLatestActionForComputer.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/maintenance-actions/latest-for-computer/{ComputerId}? |
| Return Type | `List<LatestActionForComputer>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/maintenance-actions/latest-for-computer/{ComputerId}?` and deserializes to `List<LatestActionForComputer>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<LatestActionForComputer>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
