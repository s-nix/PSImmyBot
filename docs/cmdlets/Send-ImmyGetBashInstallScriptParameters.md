---
title: Send-ImmyGetBashInstallScriptParameters
---

# Send-ImmyGetBashInstallScriptParameters

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetBashInstallScriptParameters` |
| Source | `Cmdlets/SendGetBashInstallScriptParameters.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/bash-install-script? |
| Return Type | [GetBashInstallScriptParameters](../models/GetBashInstallScriptParameters.md), [IScript](../models/IScript.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/bash-install-script?` and deserializes to [GetBashInstallScriptParameters](../models/GetBashInstallScriptParameters.md), [IScript](../models/IScript.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [GetBashInstallScriptParameters](../models/GetBashInstallScriptParameters.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetBashInstallScriptParameters](../models/GetBashInstallScriptParameters.md), [IScript](../models/IScript.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
