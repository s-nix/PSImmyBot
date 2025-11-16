---
title: Send-ImmyUpdateUserPayload
---

# Send-ImmyUpdateUserPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateUserPayload` |
| Source | `Cmdlets/SendUpdateUserPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/{UserId}? |
| Return Type | [UpdateUserPayload](../models/UpdateUserPayload.md), [GetUserResponse](../models/GetUserResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/{UserId}?` and deserializes to [UpdateUserPayload](../models/UpdateUserPayload.md), [GetUserResponse](../models/GetUserResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [UpdateUserPayload](../models/UpdateUserPayload.md) | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [UpdateUserPayload](../models/UpdateUserPayload.md), [GetUserResponse](../models/GetUserResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
