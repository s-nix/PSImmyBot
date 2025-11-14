---
title: Send-FinishAuthCodeFlowRequest
---

# Send-FinishAuthCodeFlowRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendFinishAuthCodeFlowRequest` |
| Source | `Cmdlets/SendFinishAuthCodeFlowRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/oauth/finish-auth-code-flow? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/oauth/finish-auth-code-flow?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [FinishAuthCodeFlowRequest](../models/FinishAuthCodeFlowRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
