using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record OauthConsentData(
    [property: JsonPropertyName("authorizationEndpoint")]
    Uri? AuthorizationEndpoint,
    [property: JsonPropertyName("clientId")]
    string? ClientId,
    [property: JsonPropertyName("extraQueryParameters")]
    IDictionary<string, string>? ExtraQueryParameters,
    [property: JsonPropertyName("resource")]
    string? Resource,
    [property: JsonPropertyName("scopes")] string? Scopes,
    [property: JsonPropertyName("tokenEndpoint")]
    Uri? TokenEndpoint);
