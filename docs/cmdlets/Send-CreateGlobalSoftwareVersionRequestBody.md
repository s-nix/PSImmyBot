---
title: Send-CreateGlobalSoftwareVersionRequestBody
---

# Send-CreateGlobalSoftwareVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalSoftwareVersionRequestBody` |
| Source | `Cmdlets/SendCreateGlobalSoftwareVersionRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}/versions? |
| Return Type | [CreateGlobalSoftwareVersionRequestBody](../models/CreateGlobalSoftwareVersionRequestBody.md), [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/global/{SoftwareIdentifier}/versions?` and deserializes to [CreateGlobalSoftwareVersionRequestBody](../models/CreateGlobalSoftwareVersionRequestBody.md), [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateGlobalSoftwareVersionRequestBody](../models/CreateGlobalSoftwareVersionRequestBody.md) | True | — | All | None |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateGlobalSoftwareVersionRequestBody](../models/CreateGlobalSoftwareVersionRequestBody.md), [GetGlobalSoftwareVersionResponse](../models/GetGlobalSoftwareVersionResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
