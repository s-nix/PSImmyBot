using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetProviderAgentResponse(
    [property: JsonPropertyName("agentVersion")]
    SemanticVersion AgentVersion,
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("deviceDetails")]
    DeviceDetails DeviceDetails,
    [property: JsonPropertyName("deviceUpdateFormData")]
    object? DeviceUpdateFormData,
    [property: JsonPropertyName("externalAgentId")]
    string? ExternalAgentId,
    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,
    [property: JsonPropertyName("externalClientName")]
    string? ExternalClientName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("internalData")]
    object? InternalData,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline,
    [property: JsonPropertyName("lastUpdatedUTC")]
    DateTimeOffset LastUpdatedUtc,
    [property: JsonPropertyName("onboardingOptions")]
    AgentOnboardingOptions OnboardingOptions,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId,
    [property: JsonPropertyName("requireManualIdentification")]
    bool RequireManualIdentification,
    [property: JsonPropertyName("runScriptPriority")]
    int RunScriptPriority,
    [property: JsonPropertyName("supportsRunningScripts")]
    bool SupportsRunningScripts);
