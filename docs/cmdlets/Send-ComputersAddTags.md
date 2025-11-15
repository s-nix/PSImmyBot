---
title: Send-ComputersAddTags
---

# Send-ComputersAddTags

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendComputersAddTags` |
| Source | `Cmdlets/SendComputersAddTags.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/add-tags? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/add-tags?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [AddTagsRequest](../models/AddTagsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
