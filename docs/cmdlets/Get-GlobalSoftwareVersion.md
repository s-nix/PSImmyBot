---
title: Get-GlobalSoftwareVersion
---

# Get-GlobalSoftwareVersion

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetGlobalSoftwareVersion` |
| Source | `Cmdlets/GetGlobalSoftwareVersion.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}/latest? |
| Return Type | `GetGlobalSoftwareVersionResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/software/global/{SoftwareIdentifier}/latest?` and deserializes to `GetGlobalSoftwareVersionResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetGlobalSoftwareVersionResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
