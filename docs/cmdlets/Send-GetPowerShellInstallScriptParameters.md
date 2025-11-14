---
title: Send-GetPowerShellInstallScriptParameters
---

# Send-GetPowerShellInstallScriptParameters

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetPowerShellInstallScriptParameters` |
| Source | `Cmdlets/SendGetPowerShellInstallScriptParameters.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/powershell-install-script? |
| Return Type | `GetPowerShellInstallScriptParameters, IScript` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/powershell-install-script?` and deserializes to `GetPowerShellInstallScriptParameters, IScript`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `GetPowerShellInstallScriptParameters` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetPowerShellInstallScriptParameters, IScript` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
