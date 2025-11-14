using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IProviderAgentDetails(
    [property: JsonPropertyName("agentVersion")]
    SemanticVersion AgentVersion,
    [property: JsonPropertyName("deviceDetails")]
    DeviceDetails DeviceDetails,
    [property: JsonPropertyName("externalAgentId")]
    string? ExternalAgentId,
    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,
    [property: JsonPropertyName("internalData")]
    object? InternalData,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline,
    [property: JsonPropertyName("lastUpdatedUTC")]
    DateTimeOffset LastUpdatedUtc,
    [property: JsonPropertyName("onboardingOptions")]
    AgentOnboardingOptions OnboardingOptions,
    [property: JsonPropertyName("requireManualIdentification")]
    bool RequireManualIdentification,
    [property: JsonPropertyName("supportsRunningScripts")]
    bool SupportsRunningScripts);
