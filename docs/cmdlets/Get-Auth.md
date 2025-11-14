---
title: Get-Auth
---

# Get-Auth

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAuth` |
| Source | `Cmdlets/GetAuth.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/auth? |
| Return Type | [GetAuthResponse](../models/GetAuthResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/auth?` and deserializes to [GetAuthResponse](../models/GetAuthResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetAuthResponse](../models/GetAuthResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
