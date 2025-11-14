---
title: Send-GetExecutableUriParameters
---

# Send-GetExecutableUriParameters

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetExecutableUriParameters` |
| Source | `Cmdlets/SendGetExecutableUriParameters.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/executable-uri? |
| Return Type | [GetExecutableUriParameters](../models/GetExecutableUriParameters.md), string |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/executable-uri?` and deserializes to [GetExecutableUriParameters](../models/GetExecutableUriParameters.md), string.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [GetExecutableUriParameters](../models/GetExecutableUriParameters.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetExecutableUriParameters](../models/GetExecutableUriParameters.md), string records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
