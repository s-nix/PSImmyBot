---
title: Get-ImmyComputerAgentStatusDto
---

# Get-ImmyComputerAgentStatusDto

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerAgentStatusDto` |
| Source | `Cmdlets/GetComputerAgentStatusDto.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/agent-status? |
| Return Type | List<[ComputerAgentStatusDto](../models/ComputerAgentStatusDto.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/agent-status?` and deserializes to List<[ComputerAgentStatusDto](../models/ComputerAgentStatusDto.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| LoadOptions | [DataSourceLoadOptions](../models/DataSourceLoadOptions.md) | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ComputerAgentStatusDto](../models/ComputerAgentStatusDto.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
