---
title: Send-ComputersRemoveTags
---

# Send-ComputersRemoveTags

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendComputersRemoveTags` |
| Source | `Cmdlets/SendComputersRemoveTags.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/remove-tags? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/remove-tags?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [RemoveTagsRequest](../models/RemoveTagsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
