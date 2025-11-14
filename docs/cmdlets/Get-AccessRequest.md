---
title: Get-AccessRequest
---

# Get-AccessRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAccessRequest` |
| Source | `Cmdlets/GetAccessRequest.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/persons/requesting-access? |
| Return Type | `List<AccessRequestResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/persons/requesting-access?` and deserializes to `List<AccessRequestResponse>`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `List<AccessRequestResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
