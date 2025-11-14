---
title: Update-GlobalSoftware
---

# Update-GlobalSoftware

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateGlobalSoftware` |
| Source | `Cmdlets/UpdateGlobalSoftware.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}? |
| Return Type | `UpdateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/software/global/{SoftwareIdentifier}?` and deserializes to `UpdateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `UpdateGlobalSoftwareRequestBody` | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse` records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
