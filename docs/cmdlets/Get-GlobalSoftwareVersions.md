---
title: Get-GlobalSoftwareVersions
---

# Get-GlobalSoftwareVersions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalSoftwareVersions` |
| Source | `Cmdlets/GetGlobalSoftwareVersions.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}/versions? |
| Return Type | List<[GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/global/{SoftwareIdentifier}/versions?` and deserializes to List<[GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
