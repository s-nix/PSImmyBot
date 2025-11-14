---
title: Send-CreateLocalSoftwareRequestBody
---

# Send-CreateLocalSoftwareRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalSoftwareRequestBody` |
| Source | `Cmdlets/SendCreateLocalSoftwareRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/local? |
| Return Type | [CreateLocalSoftwareRequestBody](../models/CreateLocalSoftwareRequestBody.md), [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/local?` and deserializes to [CreateLocalSoftwareRequestBody](../models/CreateLocalSoftwareRequestBody.md), [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateLocalSoftwareRequestBody](../models/CreateLocalSoftwareRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateLocalSoftwareRequestBody](../models/CreateLocalSoftwareRequestBody.md), [GetLocalSoftwareResponse](../models/GetLocalSoftwareResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
