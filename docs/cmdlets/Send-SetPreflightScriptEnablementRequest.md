---
title: Send-SetPreflightScriptEnablementRequest
---

# Send-SetPreflightScriptEnablementRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSetPreflightScriptEnablementRequest` |
| Source | `Cmdlets/SendSetPreflightScriptEnablementRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/set-preflight-script-enablement? |
| Return Type | `SetPreflightScriptEnablementRequest, OpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/set-preflight-script-enablement?` and deserializes to `SetPreflightScriptEnablementRequest, OpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `SetPreflightScriptEnablementRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `SetPreflightScriptEnablementRequest, OpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
