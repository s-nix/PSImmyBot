---
title: Get-CommandResult
---

# Get-CommandResult

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetCommandResult` |
| Source | `Cmdlets/GetCommandResult.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/functions? |
| Return Type | `List<CommandResultResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/functions?` and deserializes to `List<CommandResultResponse>`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `List<CommandResultResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
