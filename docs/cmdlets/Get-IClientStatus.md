---
title: Get-IClientStatus
---

# Get-IClientStatus

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetIClientStatus` |
| Source | `Cmdlets/GetIClientStatus.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-links/{Id}/clients/statuses? |
| Return Type | `List<IClientStatus>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-links/{Id}/clients/statuses?` and deserializes to `List<IClientStatus>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<IClientStatus>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
