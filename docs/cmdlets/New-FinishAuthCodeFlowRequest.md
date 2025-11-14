---
title: New-FinishAuthCodeFlowRequest
---

# New-FinishAuthCodeFlowRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewFinishAuthCodeFlowRequest` |
| Source | `Cmdlets/NewFinishAuthCodeFlowRequest.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AuthCode | `String` | False | — | All | None |
| OauthHookId | `Guid` | True | — | All | None |
| RedirectUriUsedInAuthLeg | `Uri` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
