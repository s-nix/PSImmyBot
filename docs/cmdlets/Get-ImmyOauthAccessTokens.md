---
title: Get-ImmyOauthAccessTokens
---

# Get-ImmyOauthAccessTokens

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOauthAccessTokens` |
| Source | `Cmdlets/GetOauthAccessTokens.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/oauth/oauth-access-tokens? |
| Return Type | List<[Oauth2AccessTokenWithTenantNameResponse](../models/Oauth2AccessTokenWithTenantNameResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/oauth/oauth-access-tokens?` and deserializes to List<[Oauth2AccessTokenWithTenantNameResponse](../models/Oauth2AccessTokenWithTenantNameResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[Oauth2AccessTokenWithTenantNameResponse](../models/Oauth2AccessTokenWithTenantNameResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
