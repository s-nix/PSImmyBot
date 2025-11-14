---
title: Get-ChocoPackageVersion
---

# Get-ChocoPackageVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetChocoPackageVersion` |
| Source | `Cmdlets/GetChocoPackageVersion.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/chocolatey/find-packages-by-id? |
| Return Type | List<[ChocoPackageVersion](../models/ChocoPackageVersion.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/chocolatey/find-packages-by-id?` and deserializes to List<[ChocoPackageVersion](../models/ChocoPackageVersion.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PackageId | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ChocoPackageVersion](../models/ChocoPackageVersion.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
