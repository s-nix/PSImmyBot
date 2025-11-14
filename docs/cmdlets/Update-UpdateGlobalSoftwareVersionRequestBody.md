---
title: Update-UpdateGlobalSoftwareVersionRequestBody
---

# Update-UpdateGlobalSoftwareVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateUpdateGlobalSoftwareVersionRequestBody` |
| Source | `Cmdlets/UpdateUpdateGlobalSoftwareVersionRequestBody.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}? |
| Return Type | [UpdateGlobalSoftwareVersionRequestBody](../models/UpdateGlobalSoftwareVersionRequestBody.md), [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}?` and deserializes to [UpdateGlobalSoftwareVersionRequestBody](../models/UpdateGlobalSoftwareVersionRequestBody.md), [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateGlobalSoftwareVersionRequestBody](../models/UpdateGlobalSoftwareVersionRequestBody.md) | True | — | All | None |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateGlobalSoftwareVersionRequestBody](../models/UpdateGlobalSoftwareVersionRequestBody.md), [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md) records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
