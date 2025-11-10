using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BeginAuthCodeFlowRequest(
    [property: JsonPropertyName("allowSilentRefresh")]
    bool AllowSilentRefresh,
    [property: JsonPropertyName("oauthConsentData")]
    OauthConsentData OauthConsentData);
