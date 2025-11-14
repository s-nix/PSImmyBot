---
title: Send-ValidateParamBlockParametersFromScriptRequest
---

# Send-ValidateParamBlockParametersFromScriptRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendValidateParamBlockParametersFromScriptRequest` |
| Source | `Cmdlets/SendValidateParamBlockParametersFromScriptRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/validate-param-block-parameters? |
| Return Type | `ValidateParamBlockParametersFromScriptRequest, DynamicFormBindResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/validate-param-block-parameters?` and deserializes to `ValidateParamBlockParametersFromScriptRequest, DynamicFormBindResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `ValidateParamBlockParametersFromScriptRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ValidateParamBlockParametersFromScriptRequest, DynamicFormBindResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
