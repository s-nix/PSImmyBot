---
title: Send-GetBashInstallScriptParameters
---

# Send-GetBashInstallScriptParameters

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetBashInstallScriptParameters` |
| Source | `Cmdlets/SendGetBashInstallScriptParameters.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/bash-install-script? |
| Return Type | `GetBashInstallScriptParameters, IScript` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/bash-install-script?` and deserializes to `GetBashInstallScriptParameters, IScript`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `GetBashInstallScriptParameters` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetBashInstallScriptParameters, IScript` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
