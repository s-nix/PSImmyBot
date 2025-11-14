---
title: Get-DisabledPreflightScripts
---

# Get-DisabledPreflightScripts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetDisabledPreflightScripts` |
| Source | `Cmdlets/GetDisabledPreflightScripts.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/disabled-preflight-scripts? |
| Return Type | List<[DisabledPreflightScriptResponse](../models/DisabledPreflightScriptResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/disabled-preflight-scripts?` and deserializes to List<[DisabledPreflightScriptResponse](../models/DisabledPreflightScriptResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[DisabledPreflightScriptResponse](../models/DisabledPreflightScriptResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
