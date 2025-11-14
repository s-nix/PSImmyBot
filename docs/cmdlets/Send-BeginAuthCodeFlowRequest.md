---
title: Send-BeginAuthCodeFlowRequest
---

# Send-BeginAuthCodeFlowRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBeginAuthCodeFlowRequest` |
| Source | `Cmdlets/SendBeginAuthCodeFlowRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/oauth/begin-auth-code-flow? |
| Return Type | [BeginAuthCodeFlowRequest](../models/BeginAuthCodeFlowRequest.md), [BeginAuthCodeFlowResponse](../models/BeginAuthCodeFlowResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/oauth/begin-auth-code-flow?` and deserializes to [BeginAuthCodeFlowRequest](../models/BeginAuthCodeFlowRequest.md), [BeginAuthCodeFlowResponse](../models/BeginAuthCodeFlowResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BeginAuthCodeFlowRequest](../models/BeginAuthCodeFlowRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [BeginAuthCodeFlowRequest](../models/BeginAuthCodeFlowRequest.md), [BeginAuthCodeFlowResponse](../models/BeginAuthCodeFlowResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
