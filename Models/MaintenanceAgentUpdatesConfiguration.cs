using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceAgentUpdatesConfiguration(
    [property: JsonPropertyName("providerLinkId")]
    int? ProviderLinkId);
