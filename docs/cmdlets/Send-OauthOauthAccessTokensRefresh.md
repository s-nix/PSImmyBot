---
title: Send-OauthOauthAccessTokensRefresh
---

# Send-OauthOauthAccessTokensRefresh

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendOauthOauthAccessTokensRefresh` |
| Source | `Cmdlets/SendOauthOauthAccessTokensRefresh.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/oauth/oauth-access-tokens/{Id}/refresh? |
| Return Type | [Oauth2AccessToken](../models/Oauth2AccessToken.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/oauth/oauth-access-tokens/{Id}/refresh?` and deserializes to [Oauth2AccessToken](../models/Oauth2AccessToken.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [Oauth2AccessToken](../models/Oauth2AccessToken.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
