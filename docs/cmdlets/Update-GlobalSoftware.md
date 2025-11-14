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
| Return Type | [UpdateGlobalSoftwareRequestBody](../models/UpdateGlobalSoftwareRequestBody.md), [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/software/global/{SoftwareIdentifier}?` and deserializes to [UpdateGlobalSoftwareRequestBody](../models/UpdateGlobalSoftwareRequestBody.md), [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateGlobalSoftwareRequestBody](../models/UpdateGlobalSoftwareRequestBody.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateGlobalSoftwareRequestBody](../models/UpdateGlobalSoftwareRequestBody.md), [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md) records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
