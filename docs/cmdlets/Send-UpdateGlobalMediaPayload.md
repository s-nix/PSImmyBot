---
title: Send-UpdateGlobalMediaPayload
---

# Send-UpdateGlobalMediaPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateGlobalMediaPayload` |
| Source | `Cmdlets/SendUpdateGlobalMediaPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/media/global/{Id}? |
| Return Type | [UpdateGlobalMediaPayload](../models/UpdateGlobalMediaPayload.md), [GlobalMediaResponse](../models/GlobalMediaResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/media/global/{Id}?` and deserializes to [UpdateGlobalMediaPayload](../models/UpdateGlobalMediaPayload.md), [GlobalMediaResponse](../models/GlobalMediaResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [UpdateGlobalMediaPayload](../models/UpdateGlobalMediaPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateGlobalMediaPayload](../models/UpdateGlobalMediaPayload.md), [GlobalMediaResponse](../models/GlobalMediaResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
