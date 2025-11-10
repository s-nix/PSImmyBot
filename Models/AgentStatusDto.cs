using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentStatusDto(
    [property: JsonPropertyName("agentId")]
    int AgentId,
    [property: JsonPropertyName("isConnected")]
    bool IsConnected,
    [property: JsonPropertyName("lastUpdatedUtc")]
    DateTimeOffset LastUpdatedUtc,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("version")]
    [property: System.ComponentModel.DataAnnotations.Required]
    SemanticVersion Version);
