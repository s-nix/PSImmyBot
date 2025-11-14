using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BeginAuthCodeFlowResponse(
    [property: JsonPropertyName("oauthHookId")]
    Guid OauthHookId);
