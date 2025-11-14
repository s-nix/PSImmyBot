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
| Return Type | `IdentifyAgentRequest, OpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-agents/identify?` and deserializes to `IdentifyAgentRequest, OpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `IdentifyAgentRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `IdentifyAgentRequest, OpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
