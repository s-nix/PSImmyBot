---
title: Get-ComputerUserAffinities
---

# Get-ComputerUserAffinities

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerUserAffinities` |
| Source | `Cmdlets/GetComputerUserAffinities.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/user-affinities? |
| Return Type | `List<ComputerUserAffinityResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/user-affinities?` and deserializes to `List<ComputerUserAffinityResponse>`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Nullable`1` | False | — | All | None |
| LoadOptions | `DataSourceLoadOptions` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<ComputerUserAffinityResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
