---
title: Send-SetExcludedFromUserAffinityRequestBody
---

# Send-SetExcludedFromUserAffinityRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSetExcludedFromUserAffinityRequestBody` |
| Source | `Cmdlets/SendSetExcludedFromUserAffinityRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/{ComputerId}/exclude-from-user-affinity? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/exclude-from-user-affinity?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | [SetExcludedFromUserAffinityRequestBody](../models/SetExcludedFromUserAffinityRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
