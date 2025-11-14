using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetProviderAgentIdentificationLogResponse([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("logType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AgentIdentificationLogType>))]
    AgentIdentificationLogType LogType,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("providerAgentId")]
    int ProviderAgentId,
    [property: JsonPropertyName("timeUtc")]
    DateTimeOffset TimeUtc);
