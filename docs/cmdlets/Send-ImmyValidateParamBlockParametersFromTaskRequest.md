---
title: Send-ImmyValidateParamBlockParametersFromTaskRequest
---

# Send-ImmyValidateParamBlockParametersFromTaskRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendValidateParamBlockParametersFromTaskRequest` |
| Source | `Cmdlets/SendValidateParamBlockParametersFromTaskRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/maintenance-tasks/validate-param-block-parameters? |
| Return Type | [ValidateParamBlockParametersFromTaskRequest](../models/ValidateParamBlockParametersFromTaskRequest.md), [DynamicFormBindResultWithConvertedParameters](../models/DynamicFormBindResultWithConvertedParameters.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/maintenance-tasks/validate-param-block-parameters?` and deserializes to [ValidateParamBlockParametersFromTaskRequest](../models/ValidateParamBlockParametersFromTaskRequest.md), [DynamicFormBindResultWithConvertedParameters](../models/DynamicFormBindResultWithConvertedParameters.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ValidateParamBlockParametersFromTaskRequest](../models/ValidateParamBlockParametersFromTaskRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ValidateParamBlockParametersFromTaskRequest](../models/ValidateParamBlockParametersFromTaskRequest.md), [DynamicFormBindResultWithConvertedParameters](../models/DynamicFormBindResultWithConvertedParameters.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
