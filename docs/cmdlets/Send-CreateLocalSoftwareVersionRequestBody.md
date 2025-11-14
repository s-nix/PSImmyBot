---
title: Send-CreateLocalSoftwareVersionRequestBody
---

# Send-CreateLocalSoftwareVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalSoftwareVersionRequestBody` |
| Source | `Cmdlets/SendCreateLocalSoftwareVersionRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/versions? |
| Return Type | [CreateLocalSoftwareVersionRequestBody](../models/CreateLocalSoftwareVersionRequestBody.md), [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/local/{SoftwareIdentifier}/versions?` and deserializes to [CreateLocalSoftwareVersionRequestBody](../models/CreateLocalSoftwareVersionRequestBody.md), [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateLocalSoftwareVersionRequestBody](../models/CreateLocalSoftwareVersionRequestBody.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateLocalSoftwareVersionRequestBody](../models/CreateLocalSoftwareVersionRequestBody.md), [GetLocalSoftwareVersionResponse](../models/GetLocalSoftwareVersionResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
