---
title: Send-UpdateUserPayload
---

# Send-UpdateUserPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateUserPayload` |
| Source | `Cmdlets/SendUpdateUserPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/{UserId}? |
| Return Type | `UpdateUserPayload, GetUserResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/{UserId}?` and deserializes to `UpdateUserPayload, GetUserResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `UpdateUserPayload` | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateUserPayload, GetUserResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
