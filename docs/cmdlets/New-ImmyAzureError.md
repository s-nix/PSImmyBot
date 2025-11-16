---
title: New-ImmyAzureError
---

# New-ImmyAzureError

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAzureError` |
| Source | `Cmdlets/NewAzureError.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ApiResponseContent | [ApiResponseErrorContent](../models/ApiResponseErrorContent.md) | True | — | All | None |
| CredentialDetails | [AzureTenantTokenCredentialDetails](../models/AzureTenantTokenCredentialDetails.md) | True | — | All | None |
| FormattedErrorMessage | `String` | False | — | All | None |
| Message | `String` | False | — | All | None |
| MissingAccessToken | [MissingAccessTokenDetails](../models/MissingAccessTokenDetails.md) | True | — | All | None |
| MsalError | [MsalErrorDetails](../models/MsalErrorDetails.md) | True | — | All | None |
| OauthAccessTokenErrorResponse | [Oauth2AccessTokenErrorResponse](../models/Oauth2AccessTokenErrorResponse.md) | True | — | All | None |
| ODataError | [ODataErrorDetails](../models/ODataErrorDetails.md) | True | — | All | None |
| PartnerCenterApiResponseDetails | [ApiResponseErrorContent](../models/ApiResponseErrorContent.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
