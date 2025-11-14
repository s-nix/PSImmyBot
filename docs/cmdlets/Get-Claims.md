---
title: Get-Claims
---

# Get-Claims

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetClaims` |
| Source | `Cmdlets/GetClaims.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/users/claims? |
| Return Type | [GetClaimsResponse](../models/GetClaimsResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/users/claims?` and deserializes to [GetClaimsResponse](../models/GetClaimsResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetClaimsResponse](../models/GetClaimsResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
