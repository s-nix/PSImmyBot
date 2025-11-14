---
title: New-ValidateParamBlockParametersFromScriptRequest
---

# New-ValidateParamBlockParametersFromScriptRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewValidateParamBlockParametersFromScriptRequest` |
| Source | `Cmdlets/NewValidateParamBlockParametersFromScriptRequest.cs` |
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
| ComputerId | `Nullable`1` | False | — | All | None |
| DatabaseType | `DatabaseType` | True | — | All | None |
| ForceRebind | `Boolean` | True | — | All | None |
| MaintenanceSessionId | `Nullable`1` | False | — | All | None |
| ParameterValues | `IDictionary`2` | False | — | All | None |
| Script | `String` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TerminalId | `Nullable`1` | False | — | All | None |
| ValidateRequiresOverrideForOnboarding | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
