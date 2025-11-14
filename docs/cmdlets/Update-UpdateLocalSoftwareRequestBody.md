---
title: Update-UpdateLocalSoftwareRequestBody
---

# Update-UpdateLocalSoftwareRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.UpdateUpdateLocalSoftwareRequestBody` |
| Source | `Cmdlets/UpdateUpdateLocalSoftwareRequestBody.cs` |
| HTTP Method | PATCH |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}? |
| Return Type | [UpdateLocalSoftwareRequestBody](../models/UpdateLocalSoftwareRequestBody.md), [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PATCH` targeting `/api/v1/software/local/{SoftwareIdentifier}?` and deserializes to [UpdateLocalSoftwareRequestBody](../models/UpdateLocalSoftwareRequestBody.md), [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateLocalSoftwareRequestBody](../models/UpdateLocalSoftwareRequestBody.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateLocalSoftwareRequestBody](../models/UpdateLocalSoftwareRequestBody.md), [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md) records produced by `ImmyBotApiService.PATCH`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
