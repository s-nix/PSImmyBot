---
title: Send-DoesScriptHaveParamBlockRequest
---

# Send-DoesScriptHaveParamBlockRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDoesScriptHaveParamBlockRequest` |
| Source | `Cmdlets/SendDoesScriptHaveParamBlockRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/does-script-have-param-block? |
| Return Type | `DoesScriptHaveParamBlockRequest, bool` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/does-script-have-param-block?` and deserializes to `DoesScriptHaveParamBlockRequest, bool`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `DoesScriptHaveParamBlockRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `DoesScriptHaveParamBlockRequest, bool` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
