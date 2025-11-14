---
title: Get-ComputersPaged
---

# Get-ComputersPaged

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputersPaged` |
| Source | `Cmdlets/GetComputersPaged.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/paged? |
| Return Type | [ComputerPageResponse](../models/ComputerPageResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/paged?` and deserializes to [ComputerPageResponse](../models/ComputerPageResponse.md).
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| DeletedOnly | `Nullable`1` | False | — | All | None |
| DevLabOnly | `Nullable`1` | False | — | All | None |
| Filter | `String` | False | — | All | None |
| IncludeOffline | `Nullable`1` | False | — | All | None |
| LicensedOnly | `Nullable`1` | False | — | All | None |
| OnboardingOnly | `Nullable`1` | False | — | All | None |
| Skip | `Nullable`1` | False | — | All | None |
| Sort | `String` | False | — | All | None |
| SortDesc | `Nullable`1` | False | — | All | None |
| StaleOnly | `Nullable`1` | False | — | All | None |
| Take | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ComputerPageResponse](../models/ComputerPageResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
