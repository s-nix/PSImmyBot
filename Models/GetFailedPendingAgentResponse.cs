using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetFailedPendingAgentResponse(
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("dateAdded")]
    DateTimeOffset DateAdded,
    [property: JsonPropertyName("deviceId")]
    string? DeviceId,
    [property: JsonPropertyName("externalAgentId")]
    string? ExternalAgentId,
    [property: JsonPropertyName("externalClientName")]
    string? ExternalClientName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("identificationFailures")]
    ICollection<GetAgentIdentificationFailureResponse>? IdentificationFailures,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline,
    [property: JsonPropertyName("operatingSystemName")]
    string? OperatingSystemName,
    [property: JsonPropertyName("osInstallDate")]
    DateTimeOffset? OsInstallDate,
    [property: JsonPropertyName("osInstallDateUtc")]
    DateTimeOffset? OsInstallDateUtc,
    [property: JsonPropertyName("providerLinkName")]
    string? ProviderLinkName,
    [property: JsonPropertyName("serial")] string? Serial);
