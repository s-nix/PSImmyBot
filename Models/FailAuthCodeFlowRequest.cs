using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FailAuthCodeFlowRequest(
    [property: JsonPropertyName("oauthErrorResponse")]
    Oauth2AuthCodeErrorResponse OauthErrorResponse,
    [property: JsonPropertyName("oauthHookId")]
    Guid OauthHookId);
