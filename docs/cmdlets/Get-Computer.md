---
title: Get-Computer
---

# Get-Computer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputer` |
| Source | `Cmdlets/GetComputer.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}? |
| Return Type | `GetComputerResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}?` and deserializes to `GetComputerResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| IncludeAdditionalPersons | `Nullable`1` | False | — | All | None |
| IncludePrimaryPerson | `Nullable`1` | False | — | All | None |
| IncludeProviderAgents | `Nullable`1` | False | — | All | None |
| IncludeProviderAgentsDeviceUpdateFormData | `Nullable`1` | False | — | All | None |
| IncludeSessions | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetComputerResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
