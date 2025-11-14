---
title: Send-GetFunctionSyntaxRequest
---

# Send-GetFunctionSyntaxRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetFunctionSyntaxRequest` |
| Source | `Cmdlets/SendGetFunctionSyntaxRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/functions/syntax? |
| Return Type | [GetFunctionSyntaxRequest](../models/GetFunctionSyntaxRequest.md), string |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/functions/syntax?` and deserializes to [GetFunctionSyntaxRequest](../models/GetFunctionSyntaxRequest.md), string.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [GetFunctionSyntaxRequest](../models/GetFunctionSyntaxRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetFunctionSyntaxRequest](../models/GetFunctionSyntaxRequest.md), string records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
