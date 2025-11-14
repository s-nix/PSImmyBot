---
title: Send-DuplicateScriptRequestBody
---

# Send-DuplicateScriptRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDuplicateScriptRequestBody` |
| Source | `Cmdlets/SendDuplicateScriptRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/scripts/duplicate? |
| Return Type | [DuplicateScriptRequestBody](../models/DuplicateScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/scripts/duplicate?` and deserializes to [DuplicateScriptRequestBody](../models/DuplicateScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [DuplicateScriptRequestBody](../models/DuplicateScriptRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [DuplicateScriptRequestBody](../models/DuplicateScriptRequestBody.md), [GetLocalScriptResponse](../models/GetLocalScriptResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
