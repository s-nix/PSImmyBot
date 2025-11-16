---
title: Send-ImmyValidateParamBlockParametersFromScriptRequest
---

# Send-ImmyValidateParamBlockParametersFromScriptRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendValidateParamBlockParametersFromScriptRequest` |
| Source | `Cmdlets/SendValidateParamBlockParametersFromScriptRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/validate-param-block-parameters? |
| Return Type | [ValidateParamBlockParametersFromScriptRequest](../models/ValidateParamBlockParametersFromScriptRequest.md), [DynamicFormBindResult](../models/DynamicFormBindResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/validate-param-block-parameters?` and deserializes to [ValidateParamBlockParametersFromScriptRequest](../models/ValidateParamBlockParametersFromScriptRequest.md), [DynamicFormBindResult](../models/DynamicFormBindResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ValidateParamBlockParametersFromScriptRequest](../models/ValidateParamBlockParametersFromScriptRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ValidateParamBlockParametersFromScriptRequest](../models/ValidateParamBlockParametersFromScriptRequest.md), [DynamicFormBindResult](../models/DynamicFormBindResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
