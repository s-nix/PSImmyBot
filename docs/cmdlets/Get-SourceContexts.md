---
title: Get-SourceContexts
---

# Get-SourceContexts

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSourceContexts` |
| Source | `Cmdlets/GetSourceContexts.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/application-logs/source-contexts? |
| Return Type | `GetSourceContextsResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/application-logs/source-contexts?` and deserializes to `GetSourceContextsResponse`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `GetSourceContextsResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
