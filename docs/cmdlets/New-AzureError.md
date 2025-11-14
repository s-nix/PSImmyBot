---
title: New-AzureError
---

# New-AzureError

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
| ApiResponseContent | `ApiResponseErrorContent` | True | — | All | None |
| CredentialDetails | `AzureTenantTokenCredentialDetails` | True | — | All | None |
| FormattedErrorMessage | `String` | False | — | All | None |
| Message | `String` | False | — | All | None |
| MissingAccessToken | `MissingAccessTokenDetails` | True | — | All | None |
| MsalError | `MsalErrorDetails` | True | — | All | None |
| OauthAccessTokenErrorResponse | `Oauth2AccessTokenErrorResponse` | True | — | All | None |
| ODataError | `ODataErrorDetails` | True | — | All | None |
| PartnerCenterApiResponseDetails | `ApiResponseErrorContent` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
