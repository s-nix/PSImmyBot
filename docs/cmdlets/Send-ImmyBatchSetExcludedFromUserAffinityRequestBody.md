---
title: Send-ImmyBatchSetExcludedFromUserAffinityRequestBody
---

# Send-ImmyBatchSetExcludedFromUserAffinityRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendBatchSetExcludedFromUserAffinityRequestBody` |
| Source | `Cmdlets/SendBatchSetExcludedFromUserAffinityRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/set-excluded-from-user-affinity? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/set-excluded-from-user-affinity?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [BatchSetExcludedFromUserAffinityRequestBody](../models/BatchSetExcludedFromUserAffinityRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
