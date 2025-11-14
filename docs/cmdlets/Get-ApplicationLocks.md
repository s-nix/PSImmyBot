---
title: Get-ApplicationLocks
---

# Get-ApplicationLocks

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetApplicationLocks` |
| Source | `Cmdlets/GetApplicationLocks.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/application-locks? |
| Return Type | List<[ApplicationLocksResponse](../models/ApplicationLocksResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/application-locks?` and deserializes to List<[ApplicationLocksResponse](../models/ApplicationLocksResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[ApplicationLocksResponse](../models/ApplicationLocksResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
