using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record ProviderAgent {
    [JsonConstructor]
    [Obsolete]
    public ProviderAgent(SemanticVersion @agentVersion, Computer @computer, int? @computerId, DateTimeOffset dateAddedUtc, DateTimeOffset? @deletedAt, string? @deletedReason, DeviceDetails @deviceDetails, string? @externalAgentId, string? @externalClientId, int @id, ICollection<AgentIdentificationFailure>? @identificationFailures, ICollection<AgentIdentificationLog>? @identificationLogs, object? @internalData, bool @isMemberOfInitialDeviceSync, bool @isOnline, DateTimeOffset lastUpdatedUtc, AgentOnboardingOptions @onboardingOptions, ProviderClient @providerClient, ProviderLink @providerLink, int @providerLinkId, bool @requireManualIdentification, bool @supportsOnlineStatus, bool @supportsRunningScripts) {
        Id = @id;
        ProviderLinkId = @providerLinkId;
        ExternalClientId = @externalClientId;
        ExternalAgentId = @externalAgentId;
        ComputerId = @computerId;
        IsOnline = @isOnline;
        SupportsOnlineStatus = @supportsOnlineStatus;
        SupportsRunningScripts = @supportsRunningScripts;
        AgentVersion = @agentVersion;
        DateAddedUtc = dateAddedUtc;
        LastUpdatedUtc = lastUpdatedUtc;
        InternalData = @internalData;
        DeviceDetails = @deviceDetails;
        OnboardingOptions = @onboardingOptions;
        RequireManualIdentification = @requireManualIdentification;
        ProviderLink = @providerLink;
        Computer = @computer;
        ProviderClient = @providerClient;
        IdentificationFailures = @identificationFailures;
        IdentificationLogs = @identificationLogs;
        IsMemberOfInitialDeviceSync = @isMemberOfInitialDeviceSync;
        DeletedAt = @deletedAt;
        DeletedReason = @deletedReason;
    }

    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("providerLinkId")]
    public int ProviderLinkId { get; init; }

    [JsonPropertyName("externalClientId")]
    public string? ExternalClientId { get; init; }

    [JsonPropertyName("externalAgentId")]
    public string? ExternalAgentId { get; init; }

    [JsonPropertyName("computerId")]
    public int? ComputerId { get; init; }

    [JsonPropertyName("isOnline")]
    public bool IsOnline { get; init; }

    [JsonPropertyName("supportsOnlineStatus")]
    [Obsolete]
    public bool SupportsOnlineStatus { get; init; }

    [JsonPropertyName("supportsRunningScripts")]
    public bool SupportsRunningScripts { get; init; }

    [JsonPropertyName("agentVersion")]
    public SemanticVersion AgentVersion { get; init; }

    [JsonPropertyName("dateAddedUTC")]
    public DateTimeOffset DateAddedUtc { get; init; }

    [JsonPropertyName("lastUpdatedUTC")]
    public DateTimeOffset LastUpdatedUtc { get; init; }

    [JsonPropertyName("internalData")]
    public object? InternalData { get; init; }

    [JsonPropertyName("deviceDetails")]
    public DeviceDetails DeviceDetails { get; init; }

    [JsonPropertyName("onboardingOptions")]
    public AgentOnboardingOptions OnboardingOptions { get; init; }

    [JsonPropertyName("requireManualIdentification")]
    public bool RequireManualIdentification { get; init; }

    [JsonPropertyName("providerLink")]
    public ProviderLink ProviderLink { get; init; }

    [JsonPropertyName("computer")]
    public Computer Computer { get; init; }

    [JsonPropertyName("providerClient")]
    public ProviderClient ProviderClient { get; init; }

    [JsonPropertyName("identificationFailures")]
    public ICollection<AgentIdentificationFailure>? IdentificationFailures { get; init; }

    [JsonPropertyName("identificationLogs")]
    public ICollection<AgentIdentificationLog>? IdentificationLogs { get; init; }

    [JsonPropertyName("isMemberOfInitialDeviceSync")]
    public bool IsMemberOfInitialDeviceSync { get; init; }

    [JsonPropertyName("deletedAt")]
    public DateTimeOffset? DeletedAt { get; init; }

    [JsonPropertyName("deletedReason")]
    public string? DeletedReason { get; init; }
}
