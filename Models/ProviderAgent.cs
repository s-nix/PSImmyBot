using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderAgent(
    [property: JsonPropertyName("id")]
    int Id,

    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,

    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,

    [property: JsonPropertyName("externalAgentId")]
    string? ExternalAgentId,

    [property: JsonPropertyName("computerId")]
    int? ComputerId,

    [property: JsonPropertyName("isOnline")]
    bool IsOnline,

    [property: JsonPropertyName("supportsOnlineStatus")]
    [property: Obsolete]
    bool SupportsOnlineStatus,

    [property: JsonPropertyName("supportsRunningScripts")]
    bool SupportsRunningScripts,

    [property: JsonPropertyName("agentVersion")]
    SemanticVersion AgentVersion,

    [property: JsonPropertyName("dateAddedUTC")]
    DateTimeOffset DateAddedUtc,

    [property: JsonPropertyName("lastUpdatedUTC")]
    DateTimeOffset LastUpdatedUtc,

    [property: JsonPropertyName("internalData")]
    object? InternalData,

    [property: JsonPropertyName("deviceDetails")]
    DeviceDetails DeviceDetails,

    [property: JsonPropertyName("onboardingOptions")]
    AgentOnboardingOptions OnboardingOptions,

    [property: JsonPropertyName("requireManualIdentification")]
    bool RequireManualIdentification,

    [property: JsonPropertyName("providerLink")]
    ProviderLink ProviderLink,

    [property: JsonPropertyName("computer")]
    Computer Computer,

    [property: JsonPropertyName("providerClient")]
    ProviderClient ProviderClient,

    [property: JsonPropertyName("identificationFailures")]
    ICollection<AgentIdentificationFailure>? IdentificationFailures,

    [property: JsonPropertyName("identificationLogs")]
    ICollection<AgentIdentificationLog>? IdentificationLogs,

    [property: JsonPropertyName("isMemberOfInitialDeviceSync")]
    bool IsMemberOfInitialDeviceSync,

    [property: JsonPropertyName("deletedAt")]
    DateTimeOffset? DeletedAt,

    [property: JsonPropertyName("deletedReason")]
    string? DeletedReason
);
