---
title: Send-ImmyRoviderLinksAgentsInstallOnComputer
---

# Send-ImmyRoviderLinksAgentsInstallOnComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderLinksAgentsInstallOnComputer` |
| Source | `Cmdlets/SendRoviderLinksAgentsInstallOnComputer.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/install-on-computer/{ComputerId}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/install-on-computer/{ComputerId}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
