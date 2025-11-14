---
title: Send-GetScriptVariablesAndParametersRequest
---

# Send-GetScriptVariablesAndParametersRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetScriptVariablesAndParametersRequest` |
| Source | `Cmdlets/SendGetScriptVariablesAndParametersRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/default-variables? |
| Return Type | `GetScriptVariablesAndParametersRequest, GetScriptVariablesAndParametersResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/default-variables?` and deserializes to `GetScriptVariablesAndParametersRequest, GetScriptVariablesAndParametersResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `GetScriptVariablesAndParametersRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetScriptVariablesAndParametersRequest, GetScriptVariablesAndParametersResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
