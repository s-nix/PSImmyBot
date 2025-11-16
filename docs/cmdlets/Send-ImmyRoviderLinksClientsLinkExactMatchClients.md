---
title: Send-ImmyRoviderLinksClientsLinkExactMatchClients
---

# Send-ImmyRoviderLinksClientsLinkExactMatchClients

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRoviderLinksClientsLinkExactMatchClients` |
| Source | `Cmdlets/SendRoviderLinksClientsLinkExactMatchClients.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/clients/link-exact-match-clients? |
| Return Type | List<[ProviderClientLinkToTenantByExactNameResponse](../models/ProviderClientLinkToTenantByExactNameResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/clients/link-exact-match-clients?` and deserializes to List<[ProviderClientLinkToTenantByExactNameResponse](../models/ProviderClientLinkToTenantByExactNameResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[ProviderClientLinkToTenantByExactNameResponse](../models/ProviderClientLinkToTenantByExactNameResponse.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
