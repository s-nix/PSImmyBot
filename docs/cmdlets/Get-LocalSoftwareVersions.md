---
title: Get-LocalSoftwareVersions
---

# Get-LocalSoftwareVersions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetLocalSoftwareVersions` |
| Source | `Cmdlets/GetLocalSoftwareVersions.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/versions? |
| Return Type | List<[GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/local/{SoftwareIdentifier}/versions?` and deserializes to List<[GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
