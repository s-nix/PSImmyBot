---
title: Send-ImmyCreateUserFromPersonRequest
---

# Send-ImmyCreateUserFromPersonRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateUserFromPersonRequest` |
| Source | `Cmdlets/SendCreateUserFromPersonRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/create-from-person? |
| Return Type | [CreateUserFromPersonRequest](../models/CreateUserFromPersonRequest.md), [GetUserResponse](../models/GetUserResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/create-from-person?` and deserializes to [CreateUserFromPersonRequest](../models/CreateUserFromPersonRequest.md), [GetUserResponse](../models/GetUserResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateUserFromPersonRequest](../models/CreateUserFromPersonRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CreateUserFromPersonRequest](../models/CreateUserFromPersonRequest.md), [GetUserResponse](../models/GetUserResponse.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
