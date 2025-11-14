---
title: Get-ProviderAgentIdentificationLog
---

# Get-ProviderAgentIdentificationLog

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetProviderAgentIdentificationLog` |
| Source | `Cmdlets/GetProviderAgentIdentificationLog.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-agents/{AgentId}/identification-logs? |
| Return Type | `List<GetProviderAgentIdentificationLogResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-agents/{AgentId}/identification-logs?` and deserializes to `List<GetProviderAgentIdentificationLogResponse>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AgentId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<GetProviderAgentIdentificationLogResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
