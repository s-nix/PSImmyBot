using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetAgentIdentificationFailureResponse(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("existingAgent")]
    IProviderAgentDetails ExistingAgent,
    [property: JsonPropertyName("existingAgentId")]
    int? ExistingAgentId,
    [property: JsonPropertyName("existingComputerName")]
    string? ExistingComputerName,
    [property: JsonPropertyName("existingManufacturer")]
    string? ExistingManufacturer,
    [property: JsonPropertyName("existingOperatingSystem")]
    string? ExistingOperatingSystem,
    [property: JsonPropertyName("existingOSInstallDate")]
    DateTimeOffset? ExistingOsInstallDate,
    [property: JsonPropertyName("existingPrimaryUserFirstName")]
    string? ExistingPrimaryUserFirstName,
    [property: JsonPropertyName("existingPrimaryUserLastName")]
    string? ExistingPrimaryUserLastName,
    [property: JsonPropertyName("existingSerialNumber")]
    string? ExistingSerialNumber,
    [property: JsonPropertyName("existingTenantName")]
    string? ExistingTenantName,
    [property: JsonPropertyName("featureUsageExceeded")]
    bool FeatureUsageExceeded,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("manualResolutionDecision")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AgentIdentificationManualResolutionDecision>))]
    AgentIdentificationManualResolutionDecision ManualResolutionDecision,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("pendingAgentId")]
    int? PendingAgentId,
    [property: JsonPropertyName("requiresManualResolution")]
    bool RequiresManualResolution,
    [property: JsonPropertyName("resolved")]
    bool Resolved);
