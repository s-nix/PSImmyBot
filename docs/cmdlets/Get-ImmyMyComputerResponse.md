---
title: Get-ImmyMyComputerResponse
---

# Get-ImmyMyComputerResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMyComputerResponse` |
| Source | `Cmdlets/GetMyComputerResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/my? |
| Return Type | List<[MyComputerResponse](../models/MyComputerResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/my?` and deserializes to List<[MyComputerResponse](../models/MyComputerResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[MyComputerResponse](../models/MyComputerResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
