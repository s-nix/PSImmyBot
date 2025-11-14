---
title: Update-UpdateLocalSoftwareVersionRequestBody
---

# Update-UpdateLocalSoftwareVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateUpdateLocalSoftwareVersionRequestBody` |
| Source | `Cmdlets/UpdateUpdateLocalSoftwareVersionRequestBody.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}? |
| Return Type | [UpdateLocalSoftwareVersionRequestBody](../models/UpdateLocalSoftwareVersionRequestBody.md), [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}?` and deserializes to [UpdateLocalSoftwareVersionRequestBody](../models/UpdateLocalSoftwareVersionRequestBody.md), [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateLocalSoftwareVersionRequestBody](../models/UpdateLocalSoftwareVersionRequestBody.md) | True | — | All | None |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateLocalSoftwareVersionRequestBody](../models/UpdateLocalSoftwareVersionRequestBody.md), [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md) records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
