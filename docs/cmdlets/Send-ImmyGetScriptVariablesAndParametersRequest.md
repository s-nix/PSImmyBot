---
title: Send-ImmyGetScriptVariablesAndParametersRequest
---

# Send-ImmyGetScriptVariablesAndParametersRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetScriptVariablesAndParametersRequest` |
| Source | `Cmdlets/SendGetScriptVariablesAndParametersRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/default-variables? |
| Return Type | [GetScriptVariablesAndParametersRequest](../models/GetScriptVariablesAndParametersRequest.md), [GetScriptVariablesAndParametersResponse](../models/GetScriptVariablesAndParametersResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/default-variables?` and deserializes to [GetScriptVariablesAndParametersRequest](../models/GetScriptVariablesAndParametersRequest.md), [GetScriptVariablesAndParametersResponse](../models/GetScriptVariablesAndParametersResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [GetScriptVariablesAndParametersRequest](../models/GetScriptVariablesAndParametersRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetScriptVariablesAndParametersRequest](../models/GetScriptVariablesAndParametersRequest.md), [GetScriptVariablesAndParametersResponse](../models/GetScriptVariablesAndParametersResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
