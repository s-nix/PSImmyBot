---
title: Send-IdentifyAgentRequest
---

# Send-IdentifyAgentRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendIdentifyAgentRequest` |
| Source | `Cmdlets/SendIdentifyAgentRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-agents/identify? |
| Return Type | [IdentifyAgentRequest](../models/IdentifyAgentRequest.md), [OpResult](../models/OpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-agents/identify?` and deserializes to [IdentifyAgentRequest](../models/IdentifyAgentRequest.md), [OpResult](../models/OpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [IdentifyAgentRequest](../models/IdentifyAgentRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [IdentifyAgentRequest](../models/IdentifyAgentRequest.md), [OpResult](../models/OpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
