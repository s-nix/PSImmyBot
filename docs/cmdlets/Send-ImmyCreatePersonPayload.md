---
title: Send-ImmyCreatePersonPayload
---

# Send-ImmyCreatePersonPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreatePersonPayload` |
| Source | `Cmdlets/SendCreatePersonPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/persons? |
| Return Type | [CreatePersonPayload](../models/CreatePersonPayload.md), [GetSimplePersonResponse](../models/GetSimplePersonResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/persons?` and deserializes to [CreatePersonPayload](../models/CreatePersonPayload.md), [GetSimplePersonResponse](../models/GetSimplePersonResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreatePersonPayload](../models/CreatePersonPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreatePersonPayload](../models/CreatePersonPayload.md), [GetSimplePersonResponse](../models/GetSimplePersonResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
