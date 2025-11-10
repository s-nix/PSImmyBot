using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureError(
    [property: JsonPropertyName("apiResponseContent")]
    ApiResponseErrorContent ApiResponseContent,
    [property: JsonPropertyName("credentialDetails")]
    AzureTenantTokenCredentialDetails CredentialDetails,
    [property: JsonPropertyName("formattedErrorMessage")]
    string? FormattedErrorMessage,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("missingAccessToken")]
    MissingAccessTokenDetails MissingAccessToken,
    [property: JsonPropertyName("msalError")]
    MsalErrorDetails MsalError,
    [property: JsonPropertyName("oauthAccessTokenErrorResponse")]
    Oauth2AccessTokenErrorResponse OauthAccessTokenErrorResponse,
    [property: JsonPropertyName("oDataError")]
    ODataErrorDetails ODataError,
    [property: JsonPropertyName("partnerCenterApiResponseDetails")]
    ApiResponseErrorContent PartnerCenterApiResponseDetails);
