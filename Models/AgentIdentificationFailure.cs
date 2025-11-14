using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentIdentificationFailure(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("existingAgentId")]
    int? ExistingAgentId,
    [property: JsonPropertyName("featureUsageExceeded")]
    bool FeatureUsageExceeded,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("manualResolutionDecision")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AgentIdentificationManualResolutionDecision>))]
    AgentIdentificationManualResolutionDecision ManualResolutionDecision,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("pendingAgent")]
    ProviderAgent PendingAgent,
    [property: JsonPropertyName("pendingAgentId")]
    int PendingAgentId,
    [property: JsonPropertyName("requiresManualResolution")]
    bool RequiresManualResolution,
    [property: JsonPropertyName("resolved")]
    bool Resolved,
    [property: JsonPropertyName("unsupportedDeviceType")]
    bool UnsupportedDeviceType);
