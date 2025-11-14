---
title: Get-AgentSha256Hash
---

# Get-AgentSha256Hash

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAgentSha256Hash` |
| Source | `Cmdlets/GetAgentSha256Hash.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/immy-agent-metadata/agent-hash? |
| Return Type | [GetAgentSha256HashResponse](../models/GetAgentSha256HashResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/immy-agent-metadata/agent-hash?` and deserializes to [GetAgentSha256HashResponse](../models/GetAgentSha256HashResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetAgentSha256HashResponse](../models/GetAgentSha256HashResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
