---
title: Get-User
---

# Get-User

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetUser` |
| Source | `Cmdlets/GetUser.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/users/{UserId}? |
| Return Type | [GetUserResponse](../models/GetUserResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/users/{UserId}?` and deserializes to [GetUserResponse](../models/GetUserResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetUserResponse](../models/GetUserResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
