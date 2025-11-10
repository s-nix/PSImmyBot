using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Oauth2AccessToken(
    [property: JsonPropertyName("accessTokenExpiresAtUtc")]
    DateTimeOffset AccessTokenExpiresAtUtc,
    [property: JsonPropertyName("accessTokenId")]
    string? AccessTokenId,
    [property: JsonPropertyName("allowSilentRefresh")]
    bool AllowSilentRefresh,
    [property: JsonPropertyName("consentData")]
    [property: System.ComponentModel.DataAnnotations.Required]
    OauthConsentData ConsentData,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("identityTokenId")]
    string? IdentityTokenId,
    [property: JsonPropertyName("refreshTokenExpiresAtUtc")]
    DateTimeOffset? RefreshTokenExpiresAtUtc,
    [property: JsonPropertyName("refreshTokenId")]
    string? RefreshTokenId,
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId,
    [property: JsonPropertyName("tokenType")]
    string? TokenType,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
