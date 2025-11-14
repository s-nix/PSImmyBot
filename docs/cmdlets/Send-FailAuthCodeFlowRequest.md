---
title: Send-FailAuthCodeFlowRequest
---

# Send-FailAuthCodeFlowRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendFailAuthCodeFlowRequest` |
| Source | `Cmdlets/SendFailAuthCodeFlowRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/oauth/fail-auth-code-flow? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/oauth/fail-auth-code-flow?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `FailAuthCodeFlowRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
