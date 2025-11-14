using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Oauth2AuthCodeErrorResponse(
    [property: JsonPropertyName("error")] string? Error,
    [property: JsonPropertyName("error_description")]
    string? ErrorDescription,
    [property: JsonPropertyName("errorDescription")]
    string? ErrorDescription2);
