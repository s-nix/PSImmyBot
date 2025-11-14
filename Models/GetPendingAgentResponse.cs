using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetPendingAgentResponse(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("dateAdded")]
    DateTimeOffset DateAdded,
    [property: JsonPropertyName("externalAgentId")]
    string? ExternalAgentId,
    [property: JsonPropertyName("externalClientName")]
    string? ExternalClientName,
    [property: JsonPropertyName("failed")] bool Failed,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("identificationFailures")]
    ICollection<GetAgentIdentificationFailureResponse>? IdentificationFailures,
    [property: JsonPropertyName("isComputerDeleted")]
    bool IsComputerDeleted,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline,
    [property: JsonPropertyName("manufacturer")]
    string? Manufacturer,
    [property: JsonPropertyName("operatingSystemName")]
    string? OperatingSystemName,
    [property: JsonPropertyName("osInstallDateUtc")]
    DateTimeOffset? OsInstallDateUtc,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("providerLinkName")]
    string? ProviderLinkName,
    [property: JsonPropertyName("requireManualIdentification")]
    bool RequireManualIdentification,
    [property: JsonPropertyName("requiresManualResolution")]
    bool RequiresManualResolution,
    [property: JsonPropertyName("serial")] string? Serial);
