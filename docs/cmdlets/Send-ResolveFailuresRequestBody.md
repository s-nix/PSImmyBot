---
title: Send-ResolveFailuresRequestBody
---

# Send-ResolveFailuresRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendResolveFailuresRequestBody` |
| Source | `Cmdlets/SendResolveFailuresRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-agents/resolve-failures? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-agents/resolve-failures?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ResolveFailuresRequestBody](../models/ResolveFailuresRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
