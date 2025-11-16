---
title: Send-ImmyCreateGlobalSoftwareRequestBody
---

# Send-ImmyCreateGlobalSoftwareRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalSoftwareRequestBody` |
| Source | `Cmdlets/SendCreateGlobalSoftwareRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/global? |
| Return Type | [CreateGlobalSoftwareRequestBody](../models/CreateGlobalSoftwareRequestBody.md), [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/global?` and deserializes to [CreateGlobalSoftwareRequestBody](../models/CreateGlobalSoftwareRequestBody.md), [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateGlobalSoftwareRequestBody](../models/CreateGlobalSoftwareRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateGlobalSoftwareRequestBody](../models/CreateGlobalSoftwareRequestBody.md), [GetGlobalSoftwareResponse](../models/GetGlobalSoftwareResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
