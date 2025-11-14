using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FinishAuthCodeFlowRequest(
    [property: JsonPropertyName("authCode")]
    string? AuthCode,
    [property: JsonPropertyName("oauthHookId")]
    Guid OauthHookId,
    [property: JsonPropertyName("redirectUriUsedInAuthLeg")]
    Uri? RedirectUriUsedInAuthLeg);
