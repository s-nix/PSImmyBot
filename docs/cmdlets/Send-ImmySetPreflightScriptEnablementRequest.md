---
title: Send-ImmySetPreflightScriptEnablementRequest
---

# Send-ImmySetPreflightScriptEnablementRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSetPreflightScriptEnablementRequest` |
| Source | `Cmdlets/SendSetPreflightScriptEnablementRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/set-preflight-script-enablement? |
| Return Type | [SetPreflightScriptEnablementRequest](../models/SetPreflightScriptEnablementRequest.md), [OpResult](../models/OpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/set-preflight-script-enablement?` and deserializes to [SetPreflightScriptEnablementRequest](../models/SetPreflightScriptEnablementRequest.md), [OpResult](../models/OpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [SetPreflightScriptEnablementRequest](../models/SetPreflightScriptEnablementRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [SetPreflightScriptEnablementRequest](../models/SetPreflightScriptEnablementRequest.md), [OpResult](../models/OpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
