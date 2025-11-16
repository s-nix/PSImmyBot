---
title: Get-ImmyOauth2AccessTokenWithTenantNameResponse
---

# Get-ImmyOauth2AccessTokenWithTenantNameResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOauth2AccessTokenWithTenantNameResponse` |
| Source | `Cmdlets/GetOauth2AccessTokenWithTenantNameResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/oauth/oauth-access-tokens/{Id}/{AccessTokenId}? |
| Return Type | [Oauth2AccessTokenWithTenantNameResponse](../models/Oauth2AccessTokenWithTenantNameResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/oauth/oauth-access-tokens/{Id}/{AccessTokenId}?` and deserializes to [Oauth2AccessTokenWithTenantNameResponse](../models/Oauth2AccessTokenWithTenantNameResponse.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AccessTokenId | `String` | True | — | All | None |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [Oauth2AccessTokenWithTenantNameResponse](../models/Oauth2AccessTokenWithTenantNameResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
