---
title: Get-IClientType
---

# Get-IClientType

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetIClientType` |
| Source | `Cmdlets/GetIClientType.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-links/{Id}/clients/types? |
| Return Type | `List<IClientType>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-links/{Id}/clients/types?` and deserializes to `List<IClientType>`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<IClientType>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
