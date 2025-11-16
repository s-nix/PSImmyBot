---
title: New-ImmyComputerAgentStatusDto
---

# New-ImmyComputerAgentStatusDto

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewComputerAgentStatusDto` |
| Source | `Cmdlets/NewComputerAgentStatusDto.cs` |
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
| Agents | `ICollection`1` | False | — | All | None |
| AllAgentsConnected | `Boolean` | True | — | All | None |
| ComputerName | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| SomeConnected | `Boolean` | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TenantName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
